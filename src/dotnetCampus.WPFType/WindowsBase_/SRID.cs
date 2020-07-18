﻿namespace System
{
    internal static partial class SRID
    {
        /// <summary>Cannot call this method on the Empty Rect.</summary>
        internal const string Rect_CannotCallMethod = nameof(Rect_CannotCallMethod);

        public static string Size_WidthAndHeightCannotBeNegative = nameof(Size_WidthAndHeightCannotBeNegative);
        public static string Size_CannotModifyEmptySize = nameof(Size_CannotModifyEmptySize);
        public static string Size_HeightCannotBeNegative = nameof(Size_HeightCannotBeNegative);
        public static string Rect_CannotModifyEmptyRect = nameof(Rect_CannotModifyEmptyRect);
        public static string Size_WidthCannotBeNegative = nameof(Size_WidthCannotBeNegative);
        public static string Transform_NotInvertible = nameof(Transform_NotInvertible);

        //private static global::System.Resources.ResourceManager s_resourceManager;
        //internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(FxResources.System.Xaml.SR)));
        //internal static global::System.Globalization.CultureInfo Culture { get; set; }

        //[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        //internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);
        /// <summary>Choice is valid only in AlternateContent.</summary>
        internal const string XCRChoiceOnlyInAC = nameof(XCRChoiceOnlyInAC);
        /// <summary>Choice cannot follow a Fallback.</summary>
        internal const string XCRChoiceAfterFallback = nameof(XCRChoiceAfterFallback);
        /// <summary>Choice must contain a Requires attribute.</summary>
        internal const string XCRRequiresAttribNotFound = nameof(XCRRequiresAttribNotFound);
        /// <summary>Requires attribute must contain a valid namespace prefix.</summary>
        internal const string XCRInvalidRequiresAttribute = nameof(XCRInvalidRequiresAttribute);
        /// <summary>Fallback is valid only in AlternateContent.</summary>
        internal const string XCRFallbackOnlyInAC = nameof(XCRFallbackOnlyInAC);
        /// <summary>AlternateContent must contain one or more Choice elements.</summary>
        internal const string XCRChoiceNotFound = nameof(XCRChoiceNotFound);
        /// <summary>AlternateContent must contain only one Fallback element.</summary>
        internal const string XCRMultipleFallbackFound = nameof(XCRMultipleFallbackFound);
        /// <summary>'{0}' attribute is not valid for '{1}' element.</summary>
        internal const string XCRInvalidAttribInElement = nameof(XCRInvalidAttribInElement);
        /// <summary>Unrecognized Compatibility element '{0}'.</summary>
        internal const string XCRUnknownCompatElement = nameof(XCRUnknownCompatElement);
        /// <summary>'{0}' element is not a valid child of AlternateContent. Only Choice and Fallback elements are valid children of an AlternateContent element.</summary>
        internal const string XCRInvalidACChild = nameof(XCRInvalidACChild);
        /// <summary>'{0}' format is not valid.</summary>
        internal const string XCRInvalidFormat = nameof(XCRInvalidFormat);
        /// <summary>'{0}' prefix is not defined.</summary>
        internal const string XCRUndefinedPrefix = nameof(XCRUndefinedPrefix);
        /// <summary>Unrecognized compatibility attribute '{0}'.</summary>
        internal const string XCRUnknownCompatAttrib = nameof(XCRUnknownCompatAttrib);
        /// <summary>'{0}' namespace cannot process content; it must be declared Ignorable first.</summary>
        internal const string XCRNSProcessContentNotIgnorable = nameof(XCRNSProcessContentNotIgnorable);
        /// <summary>Duplicate ProcessContent declaration for element '{1}' in namespace '{0}'.</summary>
        internal const string XCRDuplicateProcessContent = nameof(XCRDuplicateProcessContent);
        /// <summary>Cannot have both a specific and a wildcard ProcessContent declaration for namespace '{0}'.</summary>
        internal const string XCRInvalidProcessContent = nameof(XCRInvalidProcessContent);
        /// <summary>Duplicate wildcard ProcessContent declaration for namespace '{0}'.</summary>
        internal const string XCRDuplicateWildcardProcessContent = nameof(XCRDuplicateWildcardProcessContent);
        /// <summary>MustUnderstand condition failed on namespace '{0}'.</summary>
        internal const string XCRMustUnderstandFailed = nameof(XCRMustUnderstandFailed);
        /// <summary>'{0}' namespace cannot preserve items; it must be declared Ignorable first.</summary>
        internal const string XCRNSPreserveNotIgnorable = nameof(XCRNSPreserveNotIgnorable);
        /// <summary>Duplicate Preserve declaration for element '{1}' in namespace '{0}'.</summary>
        internal const string XCRDuplicatePreserve = nameof(XCRDuplicatePreserve);
        /// <summary>Cannot have both a specific and a wildcard Preserve declaration for namespace '{0}'.</summary>
        internal const string XCRInvalidPreserve = nameof(XCRInvalidPreserve);
        /// <summary>Duplicate wildcard Preserve declaration for namespace '{0}'.</summary>
        internal const string XCRDuplicateWildcardPreserve = nameof(XCRDuplicateWildcardPreserve);
        /// <summary>'{0}' attribute value is not a valid XML name.</summary>
        internal const string XCRInvalidXMLName = nameof(XCRInvalidXMLName);
        /// <summary>There is a cycle of XML compatibility definitions, such that namespace '{0}' overrides itself. This could be due to inconsistent XmlnsCompatibilityAttributes in different assemblies. Please change the definitions to eliminate this cycle, or pass a non-conf ...</summary>
        internal const string XCRCompatCycle = nameof(XCRCompatCycle);
        /// <summary>An XmlnsDefinitionAttribute in assembly '{0}' is missing a required property. Set both the ClrNamespace and XmlNamespace properties, or remove the XmlnsDefinitionAttribute.</summary>
        internal const string BadXmlnsDefinition = nameof(BadXmlnsDefinition);
        /// <summary>An XmlnsCompatibleWithAttribute in assembly '{0}' is missing a required property. Set both the NewNamespace and OldNamespace properties, or remove the XmlnsCompatibleWithAttribute.</summary>
        internal const string BadXmlnsCompat = nameof(BadXmlnsCompat);
        /// <summary>An XmlnsPrefixAttribute in assembly '{0}' is missing a required property. Set both the Prefix and XmlNamespace properties, or remove the XmlnsPrefixAttribute.</summary>
        internal const string BadXmlnsPrefix = nameof(BadXmlnsPrefix);
        /// <summary>One of the InternalsVisibleToAttribute values in assembly '{0}' is not a valid assembly name. Use the format 'AssemblyShortName' or 'AssemblyShortName, PublicKey=...'.</summary>
        internal const string BadInternalsVisibleTo1 = nameof(BadInternalsVisibleTo1);
        /// <summary>InternalsVisibleToAttribute value '{0}' in assembly '{1}' is not a valid assembly name. Use the format 'AssemblyShortName' or 'AssemblyShortName, PublicKey=...'.</summary>
        internal const string BadInternalsVisibleTo2 = nameof(BadInternalsVisibleTo2);
        /// <summary>There is more than one XmlnsCompatibleWithAttribute in assembly '{0}' for OldNamespace '{1}'. Remove the extra attribute(s).</summary>
        internal const string DuplicateXmlnsCompat = nameof(DuplicateXmlnsCompat);
        /// <summary>There is a cycle of XmlnsCompatibleWithAttribute definitions in assembly '{0}', such that namespace '{1}' overrides itself. Change the definitions to eliminate this cycle.</summary>
        internal const string XmlnsCompatCycle = nameof(XmlnsCompatCycle);
        /// <summary>Uri '{0}' was not found.</summary>
        internal const string UriNotFound = nameof(UriNotFound);
        /// <summary>There are conflicting XmlnsCompatibleWithAttributes in assemblies '{0}' and '{1}' for OldNamespace '{2}'. Change the attributes to have the same NewNamespace, or pass a non-conflicting set of Reference Assemblies in the XamlSchemaContext constructor.</summary>
        internal const string DuplicateXmlnsCompatAcrossAssemblies = nameof(DuplicateXmlnsCompatAcrossAssemblies);
        /// <summary>XAML namespace '{0}' is not resolved.</summary>
        internal const string UnresolvedNamespace = nameof(UnresolvedNamespace);
        /// <summary>Type reference cannot find type named '{0}'.</summary>
        internal const string TypeNotFound = nameof(TypeNotFound);
        /// <summary>Type '{0}' is not public.</summary>
        internal const string TypeNotPublic = nameof(TypeNotPublic);
        /// <summary>Only one TypeConverter attribute is allowed on a type.</summary>
        internal const string TooManyTypeConverterAttributes = nameof(TooManyTypeConverterAttributes);
        /// <summary>Cannot find Assembly '{0}' in URI '{1}'.</summary>
        internal const string CannotFindAssembly = nameof(CannotFindAssembly);
        /// <summary>No local assembly provided to complete URI='{0}'.</summary>
        internal const string MissingAssemblyName = nameof(MissingAssemblyName);
        /// <summary>Type argument '{0}' is not a valid type.</summary>
        internal const string InvalidTypeArgument = nameof(InvalidTypeArgument);
        /// <summary>Could not load file or assembly '{0}' or one of its dependencies. The system cannot find the specified file.</summary>
        internal const string FileNotFoundExceptionMessage = nameof(FileNotFoundExceptionMessage);
        /// <summary>Directive '{0}' was not found in TargetNamespace '{1}'.</summary>
        internal const string DirectiveNotFound = nameof(DirectiveNotFound);
        /// <summary>This setter is not intended to be used directly from your code. Do not call this setter.</summary>
        internal const string MustNotCallSetter = nameof(MustNotCallSetter);
        /// <summary>Missing case handler in LookupPropertyBit.</summary>
        internal const string MissingLookPropertyBit = nameof(MissingLookPropertyBit);
        /// <summary>Error with member '{0}'.'{1}'.  It has more than one '{2}'.</summary>
        internal const string TooManyAttributes = nameof(TooManyAttributes);
        /// <summary>Cannot get TargetType on a non-attachable Member.</summary>
        internal const string GetTargetTypeOnNonAttachableMember = nameof(GetTargetTypeOnNonAttachableMember);
        /// <summary>Cannot set TargetType on a non-attachable Member.</summary>
        internal const string SetTargetTypeOnNonAttachableMember = nameof(SetTargetTypeOnNonAttachableMember);
        /// <summary>Invalid expression: '{0}'</summary>
        internal const string InvalidExpression = nameof(InvalidExpression);
        /// <summary>Missing key value on '{0}' object.</summary>
        internal const string MissingKey = nameof(MissingKey);
        /// <summary>'{0}' property on '{1}' does not allow you to specify text.</summary>
        internal const string PropertyDoesNotTakeText = nameof(PropertyDoesNotTakeText);
        /// <summary>'{0}' event cannot be assigned a value that is not assignable to '{1}'.</summary>
        internal const string EventCannotBeAssigned = nameof(EventCannotBeAssigned);
        /// <summary>Failed to create a '{0}' from the text '{1}'.</summary>
        internal const string TypeConverterFailed = nameof(TypeConverterFailed);
        /// <summary>Cannot create unknown type '{0}'.</summary>
        internal const string CantCreateUnknownType = nameof(CantCreateUnknownType);
        /// <summary>Cannot set unknown member '{0}'.</summary>
        internal const string CantSetUnknownProperty = nameof(CantSetUnknownProperty);
        /// <summary>Missing implicit property case.</summary>
        internal const string MissingImplicitProperty = nameof(MissingImplicitProperty);
        /// <summary>Builder Stack is not empty when end of XamlNode stream was reached.</summary>
        internal const string BuilderStackNotEmptyOnClose = nameof(BuilderStackNotEmptyOnClose);
        /// <summary>Cannot set SchemaContext on ObjectWriter.</summary>
        internal const string CannotSetSchemaContext = nameof(CannotSetSchemaContext);
        /// <summary>Missing case for ImplicitPropertyType.</summary>
        internal const string MissingImplicitPropertyTypeCase = nameof(MissingImplicitPropertyTypeCase);
        /// <summary>Failed attempting to create an Implicit Type with a constructor.</summary>
        internal const string ConstructImplicitType = nameof(ConstructImplicitType);
        /// <summary>Type with positional parameters is not a markup extension.</summary>
        internal const string NonMEWithPositionalParameters = nameof(NonMEWithPositionalParameters);
        /// <summary>GetPositionalParameters returned the wrong length vector.</summary>
        internal const string PositionalParamsWrongLength = nameof(PositionalParamsWrongLength);
        /// <summary>Bad state in ObjectWriter. Non directive missing instance.</summary>
        internal const string BadStateObjectWriter = nameof(BadStateObjectWriter);
        /// <summary>'{0}' property has already been set on '{1}'.</summary>
        internal const string DuplicateMemberSet = nameof(DuplicateMemberSet);
        /// <summary>'{0}'.'{1}' is not an ambient property.</summary>
        internal const string NotAmbientProperty = nameof(NotAmbientProperty);
        /// <summary>'{0}' is not an ambient type.</summary>
        internal const string NotAmbientType = nameof(NotAmbientType);
        /// <summary>No constructor with '{0}' arguments for '{1}'.</summary>
        internal const string NoSuchConstructor = nameof(NoSuchConstructor);
        /// <summary>Unresolved reference '{0}'.</summary>
        internal const string UnresolvedForwardReferences = nameof(UnresolvedForwardReferences);
        /// <summary>Cannot assign root instance of type '{0}' to type '{1}'.</summary>
        internal const string CantAssignRootInstance = nameof(CantAssignRootInstance);
        /// <summary>Attempt to reference named object(s) '{0}' which have not yet been defined. Forward references, or references to objects that contain forward references, are not supported on directives other than Key.</summary>
        internal const string ForwardRefDirectives = nameof(ForwardRefDirectives);
        /// <summary>Object '{0}' assigned to directive '{1}' has properties which are references to named object(s) '{2}' which have not yet been defined. Forward references, or references to objects that contain forward references, are not supported inside object constructio ...</summary>
        internal const string TransitiveForwardRefDirectives = nameof(TransitiveForwardRefDirectives);
        /// <summary>Type '{0}' does not have a content property. Specify the name of the property to set, or add a ContentPropertyAttribute or TypeConverterAttribute on the type.</summary>
        internal const string TypeHasNoContentProperty = nameof(TypeHasNoContentProperty);
        /// <summary>Collection property '{0}'.'{1}' is null.</summary>
        internal const string GetObjectNull = nameof(GetObjectNull);
        /// <summary>The type '{0}' is not assignable from the type '{1}'.</summary>
        internal const string NotAssignableFrom = nameof(NotAssignableFrom);
        /// <summary>Name cannot be an empty string.</summary>
        internal const string NameScopeNameNotEmptyString = nameof(NameScopeNameNotEmptyString);
        /// <summary>Name '{0}' was not found.</summary>
        internal const string NameScopeNameNotFound = nameof(NameScopeNameNotFound);
        /// <summary>Cannot register duplicate name '{0}' in this scope.</summary>
        internal const string NameScopeDuplicateNamesNotAllowed = nameof(NameScopeDuplicateNamesNotAllowed);
        /// <summary>'{0}' name is not valid for identifier.</summary>
        internal const string NameScopeInvalidIdentifierName = nameof(NameScopeInvalidIdentifierName);
        /// <summary>Could not register named object. {0}</summary>
        internal const string NameScopeException = nameof(NameScopeException);
        /// <summary>'{0}' blocked the use of type '{1}' in XAML. If you want to load this type, change '{0}'.GetXamlType to return a non-null value for this type, or pass a different value in the schemaContext parameter of the XamlObjectWriter constructor.</summary>
        internal const string ObjectWriterTypeNotAllowed = nameof(ObjectWriterTypeNotAllowed);
        /// <summary>Directive '{0}' is only allowed on the root object. Remove this directive or move it to the root of the document.</summary>
        internal const string DirectiveNotAtRoot = nameof(DirectiveNotAtRoot);
        /// <summary>Directive '{0}' must be a value of type string. Remove this directive or change it to a string value.</summary>
        internal const string DirectiveMustBeString = nameof(DirectiveMustBeString);
        /// <summary>Specified class name '{0}' doesn't match actual root instance type '{1}'. Remove the Class directive or provide an instance via XamlObjectWriterSettings.RootObjectInstance.</summary>
        internal const string XClassMustMatchRootInstance = nameof(XClassMustMatchRootInstance);
        /// <summary>schemaContext parameter cannot be different from savedContext.SchemaContext</summary>
        internal const string SavedContextSchemaContextMismatch = nameof(SavedContextSchemaContextMismatch);
        /// <summary>savedContext.SchemaContext cannot be null</summary>
        internal const string SavedContextSchemaContextNull = nameof(SavedContextSchemaContextNull);
        /// <summary>Setting properties is not allowed on a type converted instance. Property = '{0}'</summary>
        internal const string SettingPropertiesIsNotAllowed = nameof(SettingPropertiesIsNotAllowed);
        /// <summary>Construction directive '{0}' must be an attribute or the first property element.</summary>
        internal const string LateConstructionDirective = nameof(LateConstructionDirective);
        /// <summary>Cannot call MarkupExtension.ProvideValue because of a cyclical dependency. Properties inside a MarkupExtension cannot reference objects that reference the result of the MarkupExtension. The affected MarkupExtensions are:</summary>
        internal const string ProvideValueCycle = nameof(ProvideValueCycle);
        /// <summary>Cannot set property '{0}' on object '{1}' because the object is a forward or incompletely initialized reference. The unresolved name(s) are: '{2}'.</summary>
        internal const string AttachedPropOnFwdRefTC = nameof(AttachedPropOnFwdRefTC);
        /// <summary>Type '{0}' cannot be initialized from text (XamlLanguage.Initialization).  Add a TypeConverter to this type or change the XAML to use a constructor or factory method.</summary>
        internal const string InitializationSyntaxWithoutTypeConverter = nameof(InitializationSyntaxWithoutTypeConverter);
        /// <summary>XAML Node Stream: StartObject '{0}' requires a StartMember after StartObject '{1}'.</summary>
        internal const string NoPropertyInCurrentFrame_SO = nameof(NoPropertyInCurrentFrame_SO);
        /// <summary>XAML Node Stream: '{0}'='{1}' Namespace Declaration requires a StartMember after StartObject '{2}'.</summary>
        internal const string NoPropertyInCurrentFrame_NS = nameof(NoPropertyInCurrentFrame_NS);
        /// <summary>XAML Node Stream: GetObject requires a StartMember after StartObject '{0}'.</summary>
        internal const string NoPropertyInCurrentFrame_GO = nameof(NoPropertyInCurrentFrame_GO);
        /// <summary>XAML Node Stream: GetObject must follow a StartObject and StartMember.</summary>
        internal const string NoPropertyInCurrentFrame_GO_noType = nameof(NoPropertyInCurrentFrame_GO_noType);
        /// <summary>XAML Node Stream: Value of '{0}' requires a StartMember after StartObject '{1}'.</summary>
        internal const string NoPropertyInCurrentFrame_V = nameof(NoPropertyInCurrentFrame_V);
        /// <summary>XAML Node Stream: Value of '{0}' must follow a StartObject and StartMember.</summary>
        internal const string NoPropertyInCurrentFrame_V_noType = nameof(NoPropertyInCurrentFrame_V_noType);
        /// <summary>XAML Node Stream: Missing EndMember for '{0}.{1}' before EndObject.</summary>
        internal const string OpenPropertyInCurrentFrame_EO = nameof(OpenPropertyInCurrentFrame_EO);
        /// <summary>XAML Node Stream: Missing EndMember for '{0}.{1}' before StartMember '{2}'.</summary>
        internal const string OpenPropertyInCurrentFrame_SM = nameof(OpenPropertyInCurrentFrame_SM);
        /// <summary>XAML Node Stream: Missing StartObject before StartMember '{0}'.</summary>
        internal const string NoTypeInCurrentFrame_SM = nameof(NoTypeInCurrentFrame_SM);
        /// <summary>XAML Node Stream: Missing CurrentObject before EndObject.</summary>
        internal const string NoTypeInCurrentFrame_EO = nameof(NoTypeInCurrentFrame_EO);
        /// <summary>XAML Node Stream: Missing StartMember on Type '{0}' before EndMember.</summary>
        internal const string NoPropertyInCurrentFrame_EM = nameof(NoPropertyInCurrentFrame_EM);
        /// <summary>XAML Node Stream: EndMember must follow StartObject and StartMember.</summary>
        internal const string NoPropertyInCurrentFrame_EM_noType = nameof(NoPropertyInCurrentFrame_EM_noType);
        /// <summary>XAML Node Stream: Value nodes must be followed by EndMember.</summary>
        internal const string ValueMustBeFollowedByEndMember = nameof(ValueMustBeFollowedByEndMember);
        /// <summary>Dictionary of type '{0}' cannot add key '{1}'. A TypeConverter will convert the key to type '{2}'. To avoid seeing this error, override System.Collections.IDictionary.Add and perform the conversion there.</summary>
        internal const string DictionaryFirstChanceException = nameof(DictionaryFirstChanceException);
        /// <summary>BaseUri can only be set once at the root node (XamlXmlReader may provide a default at the root node).</summary>
        internal const string CannotSetBaseUri = nameof(CannotSetBaseUri);
        /// <summary>'{0}'.'{1}' Depends on '{0}'.{1}', which was not set.</summary>
        internal const string DependsOnMissing = nameof(DependsOnMissing);
        /// <summary>Close called while inside a deferred load section.</summary>
        internal const string CloseInsideTemplate = nameof(CloseInsideTemplate);
        /// <summary>Unexpected close of XAML Node Stream.</summary>
        internal const string UnexpectedClose = nameof(UnexpectedClose);
        /// <summary>Deferred load section was not collected in '{0}'.</summary>
        internal const string TemplateNotCollected = nameof(TemplateNotCollected);
        /// <summary>Deferred member was not collected in '{0}'.</summary>
        internal const string DeferredPropertyNotCollected = nameof(DeferredPropertyNotCollected);
        /// <summary>Missing case '{0}' in DeferringWriter'{1}' method.</summary>
        internal const string MissingCase = nameof(MissingCase);
        /// <summary>Namespace '{0}' was not found in scope.</summary>
        internal const string NamespaceNotFound = nameof(NamespaceNotFound);
        /// <summary>Cannot attach NameScope to null root instance.</summary>
        internal const string NameScopeOnRootInstance = nameof(NameScopeOnRootInstance);
        /// <summary>Service provider is missing the INameResolver service.</summary>
        internal const string MissingNameResolver = nameof(MissingNameResolver);
        /// <summary>Argument should be a Type Converter, Markup Extension or Null.</summary>
        internal const string ObjectNotTcOrMe = nameof(ObjectNotTcOrMe);
        /// <summary>Directly Assignable Fixups must only have one name.</summary>
        internal const string SimpleFixupsMustHaveOneName = nameof(SimpleFixupsMustHaveOneName);
        /// <summary>Unexpected token after end of markup extension.</summary>
        internal const string UnexpectedTokenAfterME = nameof(UnexpectedTokenAfterME);
        /// <summary>White space is not allowed after end of markup extension.</summary>
        internal const string WhitespaceAfterME = nameof(WhitespaceAfterME);
        /// <summary>Unexpected token '{0}' in rule: '{1}', in '{2}'.</summary>
        internal const string UnexpectedToken = nameof(UnexpectedToken);
        /// <summary>A Constructor for '{0}' with '{1}' arguments was not found.</summary>
        internal const string NoConstructorWithNArugments = nameof(NoConstructorWithNArugments);
        /// <summary>Unexpected equals sign '=' following '{0}'. Check for a missing comma separator.</summary>
        internal const string MissingComma1 = nameof(MissingComma1);
        /// <summary>Unexpected equals sign '=' following '{0}'='{1}'. Check for a missing comma separator.</summary>
        internal const string MissingComma2 = nameof(MissingComma2);
        /// <summary>Type name '{0}' cannot have a dot '.'.</summary>
        internal const string TypeNameCannotHavePeriod = nameof(TypeNameCannotHavePeriod);
        /// <summary>Unexpected '{0}' in parse rule '{1}'.</summary>
        internal const string UnexpectedNodeType = nameof(UnexpectedNodeType);
        /// <summary>Element ::= . EmptyElement | ( StartElement ElementBody ).</summary>
        internal const string ElementRuleException = nameof(ElementRuleException);
        /// <summary>EmptyElement ::= . EMPTYELEMENT DIRECTIVE* ATTRIBUTE*.</summary>
        internal const string EmptyElementRuleException = nameof(EmptyElementRuleException);
        /// <summary>EmptyPropertyElement ::= EMPTYPROPERTYELEMENT.</summary>
        internal const string EmptyPropertyElementRuleException = nameof(EmptyPropertyElementRuleException);
        /// <summary>StartElement ::= . ELEMENT DIRECTIVE*.</summary>
        internal const string StartElementRuleException = nameof(StartElementRuleException);
        /// <summary>ElementBody ::= ATTRIBUTE* ( PropertyElement | Content )* . ENDTAG.</summary>
        internal const string ElementBodyRuleException = nameof(ElementBodyRuleException);
        /// <summary>NonemptyPropertyElement ::= . PROPERTYELEMENT Content? ENDTAG.</summary>
        internal const string NonemptyPropertyElementRuleException = nameof(NonemptyPropertyElementRuleException);
        /// <summary>PropertyElement ::= EmptyPropertyElement | NonemptyPropertyElement</summary>
        internal const string PropertyElementRuleException = nameof(PropertyElementRuleException);
        /// <summary>Missing '{0}' in URI '{1}'.</summary>
        internal const string MissingTagInNamespace = nameof(MissingTagInNamespace);
        /// <summary>Part between semicolon ';' and equals sign '=' is not '{0}' URI '{1}'.</summary>
        internal const string AssemblyTagMissing = nameof(AssemblyTagMissing);
        /// <summary>['{0}'('{1}')] on '{2}' is not a known property.</summary>
        internal const string UnknownAttributeProperty = nameof(UnknownAttributeProperty);
        /// <summary>['{0}'('{1}')] on '{2}' is not a property declared on this type.</summary>
        internal const string NotDeclaringTypeAttributeProperty = nameof(NotDeclaringTypeAttributeProperty);
        /// <summary>Error with type '{0}'. MarkupExtensions cannot use the 'UsableDuringInitialization' attribute.</summary>
        internal const string UsableDuringInitializationOnME = nameof(UsableDuringInitializationOnME);
        /// <summary>Error with type '{0}'.  It has more than one '{1}'.</summary>
        internal const string TooManyAttributesOnType = nameof(TooManyAttributesOnType);
        /// <summary>Missing case in ClrType 'Member' lookup.</summary>
        internal const string MissingPropertyCaseClrType = nameof(MissingPropertyCaseClrType);
        /// <summary>Unhandled BoolTypeBit.</summary>
        internal const string UnhandledBoolTypeBit = nameof(UnhandledBoolTypeBit);
        /// <summary>Cannot determine the item type of collection type '{0}' because it has more than one Add method or ICollection&lt;T&gt; implementation. To make this collection type usable in XAML, add a public Add(object) method, implement System.Collections.IList or a single S ...</summary>
        internal const string AmbiguousCollectionItemType = nameof(AmbiguousCollectionItemType);
        /// <summary>Cannot determine the item type of dictionary type '{0}' because it has more than one Add method or IDictionary&lt;K,V&gt; implementation. To make this dictionary type usable in XAML, add a public Add(object,object) method, implement System.Collections.IDictionar ...</summary>
        internal const string AmbiguousDictionaryItemType = nameof(AmbiguousDictionaryItemType);
        /// <summary>Cannot determine the positional parameters for type '{0}' because it has more than one constructor overload with '{1}' parameters. To make this markup extension usable in XAML, remove the duplicate constructor overload(s) or set XamlSchemaContextSettings.S ...</summary>
        internal const string MarkupExtensionWithDuplicateArity = nameof(MarkupExtensionWithDuplicateArity);
        /// <summary>'{0}'.'{1}' is a property without a getter and is not a valid XAML property.</summary>
        internal const string SetOnlyProperty = nameof(SetOnlyProperty);
        /// <summary>Need to implement public/internal sorting.</summary>
        internal const string XaslTypePropertiesNotImplemented = nameof(XaslTypePropertiesNotImplemented);
        /// <summary>Attachable member '{0}' was not found.</summary>
        internal const string AttachableMemberNotFound = nameof(AttachableMemberNotFound);
        /// <summary>'{0}' is not implemented.</summary>
        internal const string PropertyNotImplemented = nameof(PropertyNotImplemented);
        /// <summary>Prefix '{0}' does not map to a namespace.</summary>
        internal const string PrefixNotFound = nameof(PrefixNotFound);
        /// <summary>'{0}' Line number '{1}' and line position '{2}'.</summary>
        internal const string LineNumberAndPosition = nameof(LineNumberAndPosition);
        /// <summary>'{0}' Line number '{1}'.</summary>
        internal const string LineNumberOnly = nameof(LineNumberOnly);
        /// <summary>Quote characters ' or " are only allowed at the start of values.</summary>
        internal const string QuoteCharactersOutOfPlace = nameof(QuoteCharactersOutOfPlace);
        /// <summary>Unclosed quoted value.</summary>
        internal const string UnclosedQuote = nameof(UnclosedQuote);
        /// <summary>Cannot parse the malformed property name '{0}'.</summary>
        internal const string MalformedPropertyName = nameof(MalformedPropertyName);
        /// <summary>An unhandled scanner attribute was encountered.</summary>
        internal const string AttributeUnhandledKind = nameof(AttributeUnhandledKind);
        /// <summary>Unknown type '{0}'.</summary>
        internal const string UnknownType = nameof(UnknownType);
        /// <summary>Unknown member '{0}' on '{1}'.</summary>
        internal const string UnknownMember = nameof(UnknownMember);
        /// <summary>Unknown member '{0}'.</summary>
        internal const string UnknownMemberSimple = nameof(UnknownMemberSimple);
        /// <summary>Unknown member '{0}' on unknown type '{1}'.</summary>
        internal const string UnknownMemberOnUnknownType = nameof(UnknownMemberOnUnknownType);
        /// <summary>Member '{0}' on type '{1}' is internal.</summary>
        internal const string MemberIsInternal = nameof(MemberIsInternal);
        /// <summary>'{0}' is not allowed in attribute usage.</summary>
        internal const string NoAttributeUsage = nameof(NoAttributeUsage);
        /// <summary>'{0}' is not allowed in element usage.</summary>
        internal const string NoElementUsage = nameof(NoElementUsage);
        /// <summary>'{0}' is not a valid XAML member name.</summary>
        internal const string InvalidXamlMemberName = nameof(InvalidXamlMemberName);
        /// <summary>The property element '{0}' is not contained by an object element.</summary>
        internal const string ParentlessPropertyElement = nameof(ParentlessPropertyElement);
        /// <summary>SchemaContext on writer must be initialized before accessing the reader.</summary>
        internal const string SchemaContextNotInitialized = nameof(SchemaContextNotInitialized);
        /// <summary>Thread is already started.</summary>
        internal const string ThreadAlreadyStarted = nameof(ThreadAlreadyStarted);
        /// <summary>SchemaContext cannot be null.</summary>
        internal const string SchemaContextNull = nameof(SchemaContextNull);
        /// <summary>Must close XamlWriter before reading from XamlNodeList.</summary>
        internal const string CloseXamlWriterBeforeReading = nameof(CloseXamlWriterBeforeReading);
        /// <summary>Cannot write on a closed XamlWriter.</summary>
        internal const string CannotWriteClosedWriter = nameof(CannotWriteClosedWriter);
        /// <summary>An attempt was made to write to a XamlWriter that has had its Closed method called.</summary>
        internal const string WriterIsClosed = nameof(WriterIsClosed);
        /// <summary>Directive getter is not implemented.</summary>
        internal const string DirectiveGetter = nameof(DirectiveGetter);
        /// <summary>Bad method '{0}' on '{1}'.</summary>
        internal const string BadMethod = nameof(BadMethod);
        /// <summary>Cannot resolve type '{0}' for method '{1}'.</summary>
        internal const string CannotResolveTypeForFactoryMethod = nameof(CannotResolveTypeForFactoryMethod);
        /// <summary>Cannot create an instance of '{0}' because XamlType is not valid.</summary>
        internal const string CannotCreateBadType = nameof(CannotCreateBadType);
        /// <summary>Cannot create an instance of '{0}' because XamlType is not valid.</summary>
        internal const string CannotCreateBadEventDelegate = nameof(CannotCreateBadEventDelegate);
        /// <summary>Attachable events are not implemented.</summary>
        internal const string AttachableEventNotImplemented = nameof(AttachableEventNotImplemented);
        /// <summary>List collection is not an IList.</summary>
        internal const string ListNotIList = nameof(ListNotIList);
        /// <summary>Array Add method is not implemented.</summary>
        internal const string ArrayAddNotImplemented = nameof(ArrayAddNotImplemented);
        /// <summary>No Add methods found on type '{0}' for a value of type '{1}'.</summary>
        internal const string NoAddMethodFound = nameof(NoAddMethodFound);
        /// <summary>Creating from text without a TypeConverter is not allowed.</summary>
        internal const string MissingTypeConverter = nameof(MissingTypeConverter);
        /// <summary>Cannot set read-only property '{0}'.</summary>
        internal const string CantSetReadonlyProperty = nameof(CantSetReadonlyProperty);
        /// <summary>Cannot get write-only property '{0}'.</summary>
        internal const string CantGetWriteonlyProperty = nameof(CantGetWriteonlyProperty);
        /// <summary>The value for XmlData property '{0}' is null or not IXmlSerializable.</summary>
        internal const string XmlDataNull = nameof(XmlDataNull);
        /// <summary>The value for XmlData property '{0}' is not an XmlReader.</summary>
        internal const string XmlValueNotReader = nameof(XmlValueNotReader);
        /// <summary>Name resolution failure. '{0}' was not found.</summary>
        internal const string NameNotFound = nameof(NameNotFound);
        /// <summary>Reference must have a Name to resolve.</summary>
        internal const string MustHaveName = nameof(MustHaveName);
        /// <summary>The invocation of a method '{0}' that matches the specified binding constraints threw an exception.</summary>
        internal const string MethodInvocation = nameof(MethodInvocation);
        /// <summary>Get property '{0}' threw an exception.</summary>
        internal const string GetValue = nameof(GetValue);
        /// <summary>Set property '{0}' threw an exception.</summary>
        internal const string SetValue = nameof(SetValue);
        /// <summary>Add value to collection of type '{0}' threw an exception.</summary>
        internal const string AddCollection = nameof(AddCollection);
        /// <summary>Add value to dictionary of type '{0}' threw an exception.</summary>
        internal const string AddDictionary = nameof(AddDictionary);
        /// <summary>Set connectionId threw an exception.</summary>
        internal const string SetConnectionId = nameof(SetConnectionId);
        /// <summary>Initialization of '{0}' threw an exception.</summary>
        internal const string InitializationGuard = nameof(InitializationGuard);
        /// <summary>Setting xml:base on '{0}' threw an exception.</summary>
        internal const string SetUriBase = nameof(SetUriBase);
        /// <summary>Provide value on '{0}' threw an exception.</summary>
        internal const string ProvideValue = nameof(ProvideValue);
        /// <summary>Setting xml instance on '{0}' threw an exception.</summary>
        internal const string SetXmlInstance = nameof(SetXmlInstance);
        /// <summary>Getting instance of '{0}' threw an exception.</summary>
        internal const string GetConverterInstance = nameof(GetConverterInstance);
        /// <summary>Deferred load threw an exception.</summary>
        internal const string DeferredLoad = nameof(DeferredLoad);
        /// <summary>Save of deferred-load content threw an exception.</summary>
        internal const string DeferredSave = nameof(DeferredSave);
        /// <summary>The factory method '{0}' that matches the specified binding constraints returned null.</summary>
        internal const string FactoryReturnedNull = nameof(FactoryReturnedNull);
        /// <summary>The invocation of the constructor on type '{0}' that matches the specified binding constraints threw an exception.</summary>
        internal const string ConstructorInvocation = nameof(ConstructorInvocation);
        /// <summary>No default constructor found for type '{0}'. You can use the Arguments or FactoryMethod directives to construct this type.</summary>
        internal const string NoDefaultConstructor = nameof(NoDefaultConstructor);
        /// <summary>No matching constructor found on type '{0}'. You can use the Arguments or FactoryMethod directives to construct this type.</summary>
        internal const string NoConstructor = nameof(NoConstructor);
        /// <summary>Cannot get a XamlDeferringLoader from XamlValueConverter '{0}' because its ConverterInstance property is null.</summary>
        internal const string DeferringLoaderInstanceNull = nameof(DeferringLoaderInstanceNull);
        /// <summary>Failed to convert '{0}' to type '{1}'.</summary>
        internal const string TypeConverterFailed2 = nameof(TypeConverterFailed2);
        /// <summary>Failed to check convertibility from type '{0}' using '{1}'. This generally indicates an incorrectly implemented TypeConverter.</summary>
        internal const string CanConvertFromFailed = nameof(CanConvertFromFailed);
        /// <summary>Failed to check convertibility to type '{0}' using '{1}'. This generally indicates an incorrectly implemented TypeConverter.</summary>
        internal const string CanConvertToFailed = nameof(CanConvertToFailed);
        /// <summary>ShouldSerialize check failed for member '{0}'.</summary>
        internal const string ShouldSerializeFailed = nameof(ShouldSerializeFailed);
        /// <summary>XamlTypeInvoker.GetItems returned null for type '{0}'. This generally indicates an incorrectly implemented collection type.</summary>
        internal const string GetItemsReturnedNull = nameof(GetItemsReturnedNull);
        /// <summary>Retrieving items in collection or dictionary of type '{0}' threw an exception.</summary>
        internal const string GetItemsException = nameof(GetItemsException);
        /// <summary>Enumerating attached properties on object '{0}' threw an exception.</summary>
        internal const string APSException = nameof(APSException);
        /// <summary>Cannot reassign a previously set SchemaContext.</summary>
        internal const string CannotReassignSchemaContext = nameof(CannotReassignSchemaContext);
        /// <summary>Cannot set SchemaContext to null.</summary>
        internal const string CannotSetSchemaContextNull = nameof(CannotSetSchemaContextNull);
        /// <summary>Missing case in Default processing of XamlNodes.</summary>
        internal const string MissingCaseXamlNodes = nameof(MissingCaseXamlNodes);
        /// <summary>TypeExtension must have TypeName property set before ProvideValue can be called.</summary>
        internal const string MarkupExtensionTypeName = nameof(MarkupExtensionTypeName);
        /// <summary>'{0}' string is not valid for type.</summary>
        internal const string MarkupExtensionTypeNameBad = nameof(MarkupExtensionTypeNameBad);
        /// <summary>Markup extension '{0}' requires '{1}' be implemented in the IServiceProvider for ProvideValue.</summary>
        internal const string MarkupExtensionNoContext = nameof(MarkupExtensionNoContext);
        /// <summary>Unable to call '{0}' in current state.</summary>
        internal const string XamlXmlWriterWriteNotSupportedInCurrentState = nameof(XamlXmlWriterWriteNotSupportedInCurrentState);
        /// <summary>Unable to call WriteObject with isObjectFromMember set to true in current state.</summary>
        internal const string XamlXmlWriterWriteObjectNotSupportedInCurrentState = nameof(XamlXmlWriterWriteObjectNotSupportedInCurrentState);
        /// <summary>The prefix '{0}' is already defined in current scope.</summary>
        internal const string XamlXmlWriterPrefixAlreadyDefinedInCurrentScope = nameof(XamlXmlWriterPrefixAlreadyDefinedInCurrentScope);
        /// <summary>Namespace '{0}' already has a prefix defined in current scope.</summary>
        internal const string XamlXmlWriterNamespaceAlreadyHasPrefixInCurrentScope = nameof(XamlXmlWriterNamespaceAlreadyHasPrefixInCurrentScope);
        /// <summary>The member '{0}' has already been written.</summary>
        internal const string XamlXmlWriterDuplicateMember = nameof(XamlXmlWriterDuplicateMember);
        /// <summary>The argument isObjectFromMember can only be set to true when the type is a collection.</summary>
        internal const string XamlXmlWriterIsObjectFromMemberSetForArraysOrNonCollections = nameof(XamlXmlWriterIsObjectFromMemberSetForArraysOrNonCollections);
        /// <summary>Cannot write a value that is not a string.</summary>
        internal const string XamlXmlWriterCannotWriteNonstringValue = nameof(XamlXmlWriterCannotWriteNonstringValue);
        /// <summary>Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters due to the lack of a default ...</summary>
        internal const string ExpandPositionalParametersinTypeWithNoDefaultConstructor = nameof(ExpandPositionalParametersinTypeWithNoDefaultConstructor);
        /// <summary>Cannot write the given positional parameters because a matching constructor was not found.</summary>
        internal const string ConstructorNotFoundForGivenPositionalParameters = nameof(ConstructorNotFoundForGivenPositionalParameters);
        /// <summary>Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters since not all properties are ...</summary>
        internal const string ExpandPositionalParametersWithReadOnlyProperties = nameof(ExpandPositionalParametersWithReadOnlyProperties);
        /// <summary>The name of the type '{0}' contains characters that are invalid in XAML.</summary>
        internal const string TypeHasInvalidXamlName = nameof(TypeHasInvalidXamlName);
        /// <summary>The name of the member '{0}' contains characters that are invalid in XAML.</summary>
        internal const string MemberHasInvalidXamlName = nameof(MemberHasInvalidXamlName);
        /// <summary>The prefix 'xml' is reserved.</summary>
        internal const string NamespaceDeclarationCannotBeXml = nameof(NamespaceDeclarationCannotBeXml);
        /// <summary>Cannot write positional parameters in the current state.  The writer cannot write the positional parameters in attribute form because the writer has started to write elements, nor can the writer expand the positional parameters since UnderlyingType on type ...</summary>
        internal const string ExpandPositionalParametersWithoutUnderlyingType = nameof(ExpandPositionalParametersWithoutUnderlyingType);
        /// <summary>The prefix '{0}' could not be found.</summary>
        internal const string PrefixNotInFrames = nameof(PrefixNotInFrames);
        /// <summary>XamlXmlWriter cannot write value '{0}' which contains significant white space in collection '{1}'.</summary>
        internal const string WhiteSpaceInCollection = nameof(WhiteSpaceInCollection);
        /// <summary>The value '{1}' contains significant white space(s) but "xml:space = preserve" cannot be written down on the member '{0}'.</summary>
        internal const string CannotWriteXmlSpacePreserveOnMember = nameof(CannotWriteXmlSpacePreserveOnMember);
        /// <summary>The string '{0}' is not a valid XAML type name. Type names contain an optional prefix, a name, and optional type arguments; such as 'String', 'x:Int32', 'g:Dictionary(x:String,x:Int32)'.</summary>
        internal const string InvalidTypeString = nameof(InvalidTypeString);
        /// <summary>The string '{0}' is not a valid XAML type name list. Type name lists are comma-delimited lists of types; such as 'x:String, x:Int32'.</summary>
        internal const string InvalidTypeListString = nameof(InvalidTypeListString);
        /// <summary>Character '{0}' was unexpected in string '{1}'.  Invalid XAML type name.</summary>
        internal const string InvalidCharInTypeName = nameof(InvalidCharInTypeName);
        /// <summary>Cannot convert this XamlTypeName instance to a string because the Namespace property is null. Set the Namespace property before calling XamlTypeName.ToString.</summary>
        internal const string XamlTypeNameNamespaceIsNull = nameof(XamlTypeNameNamespaceIsNull);
        /// <summary>Cannot convert this XamlTypeName instance to a string because the Name property is null or empty. Set the Name property before calling XamlTypeName.ToString.</summary>
        internal const string XamlTypeNameNameIsNullOrEmpty = nameof(XamlTypeNameNameIsNullOrEmpty);
        /// <summary>Cannot convert this XamlTypeName instance to a string because the provided INamespacePrefixLookup could not generate a prefix for the namespace '{0}'.</summary>
        internal const string XamlTypeNameCannotGetPrefix = nameof(XamlTypeNameCannotGetPrefix);
        /// <summary>Collection '{0}' cannot contain null values.</summary>
        internal const string CollectionCannotContainNulls = nameof(CollectionCannotContainNulls);
        /// <summary>NamespaceDeclaration.Prefix cannot be null.  Provide a value for this property.</summary>
        internal const string NamespaceDeclarationPrefixCannotBeNull = nameof(NamespaceDeclarationPrefixCannotBeNull);
        /// <summary>NamespaceDeclaration.Namespace cannot be null.  Provide a value for this property.</summary>
        internal const string NamespaceDeclarationNamespaceCannotBeNull = nameof(NamespaceDeclarationNamespaceCannotBeNull);
        /// <summary>Attached property getter methods must have one parameter and a non-void return type.</summary>
        internal const string IncorrectGetterParamNum = nameof(IncorrectGetterParamNum);
        /// <summary>Attached property setter and attached event adder methods must have two parameters.</summary>
        internal const string IncorrectSetterParamNum = nameof(IncorrectSetterParamNum);
        /// <summary>Either getter or setter must be non-null.</summary>
        internal const string GetterOrSetterRequired = nameof(GetterOrSetterRequired);
        /// <summary>Unable to locate MemberMarkupInfo.DictionaryEntriesFromGeneric method.</summary>
        internal const string ObjectReaderDictionaryMethod1NotFound = nameof(ObjectReaderDictionaryMethod1NotFound);
        /// <summary>An element with the name '{0}' has already been registered in this scope.</summary>
        internal const string ObjectReaderXamlNamedElementAlreadyRegistered = nameof(ObjectReaderXamlNamedElementAlreadyRegistered);
        /// <summary>The object graph contains multiple references to an instance of type '{0}' and the serializer cannot find a commonly visible location to write the instance. You should examine your use of name scopes.</summary>
        internal const string ObjectReaderXamlNameScopeResultsInClonedObject = nameof(ObjectReaderXamlNameScopeResultsInClonedObject);
        /// <summary>The name property '{0}' on type '{1}' must be of type System.String.</summary>
        internal const string ObjectReaderXamlNamePropertyMustBeString = nameof(ObjectReaderXamlNamePropertyMustBeString);
        /// <summary>Unable to serialize type '{0}'.  Verify that the type is public and either has a default constructor or an instance descriptor.</summary>
        internal const string ObjectReaderNoDefaultConstructor = nameof(ObjectReaderNoDefaultConstructor);
        /// <summary>Unable to find a suitable constructor for the specified constructor arguments on type '{0}'.</summary>
        internal const string ObjectReaderNoMatchingConstructor = nameof(ObjectReaderNoMatchingConstructor);
        /// <summary>InstanceDescriptor provided an argument of type '{0}' where a parameter of type '{1}' was expected.</summary>
        internal const string ObjectReaderInstanceDescriptorIncompatibleArgumentTypes = nameof(ObjectReaderInstanceDescriptorIncompatibleArgumentTypes);
        /// <summary>InstanceDescriptor did not provide the correct number of arguments.</summary>
        internal const string ObjectReaderInstanceDescriptorIncompatibleArguments = nameof(ObjectReaderInstanceDescriptorIncompatibleArguments);
        /// <summary>InstanceDescriptor did not provide a valid constructor or method.</summary>
        internal const string ObjectReaderInstanceDescriptorInvalidMethod = nameof(ObjectReaderInstanceDescriptorInvalidMethod);
        /// <summary>Unable to read objects of the type ‘{0}’ because there are no accessible constructors. To allow this type to be used in XAML, add a default constructor, use ConstructorArgumentAttribute, or provide an InstanceDescriptor.</summary>
        internal const string ObjectReaderTypeCannotRoundtrip = nameof(ObjectReaderTypeCannotRoundtrip);
        /// <summary>Unable to read objects of the type '{0}'.  Nested types are not supported.</summary>
        internal const string ObjectReaderTypeIsNested = nameof(ObjectReaderTypeIsNested);
        /// <summary>Unable to find an attachable property named '{0}' on type '{1}'.</summary>
        internal const string ObjectReaderAttachedPropertyNotFound = nameof(ObjectReaderAttachedPropertyNotFound);
        /// <summary>Unexpected XAML node type '{0}' from XamlReader in XamlFactory.</summary>
        internal const string XamlFactoryInvalidXamlNode = nameof(XamlFactoryInvalidXamlNode);
        /// <summary>In markup extensions, all constructor argument values should be atoms.  For the object of type '{0}', one or more argument values are not atomic.</summary>
        internal const string CannotAddPositionalParameters = nameof(CannotAddPositionalParameters);
        /// <summary>Multidimensional arrays not supported.</summary>
        internal const string ObjectReaderMultidimensionalArrayNotSupported = nameof(ObjectReaderMultidimensionalArrayNotSupported);
        /// <summary>'{0}' blocked the use of type '{1}' in XAML. If you want to serialize this type, change '{0}'.GetXamlType to return a non-null value for this type, or pass a different value in the schemaContext parameter of the XamlObjectReader constructor.</summary>
        internal const string ObjectReaderTypeNotAllowed = nameof(ObjectReaderTypeNotAllowed);
        /// <summary>Type '{0}' not visible. If the type is local, please set the LocalAssembly field in XamlReaderSettings.</summary>
        internal const string ObjectReader_TypeNotVisible = nameof(ObjectReader_TypeNotVisible);
        /// <summary>Expected value of type ObjectMarkupInfo.</summary>
        internal const string ExpectedObjectMarkupInfo = nameof(ExpectedObjectMarkupInfo);
        /// <summary>An attachable property named '{2}' is attached to a property named '{1}'.  The property named '{1}' is either a string or can be type-converted to string; attaching on such properties are not supported.  For debugging, the property '{1}' contains an object ...</summary>
        internal const string AttachedPropertyOnTypeConvertedOrStringProperty = nameof(AttachedPropertyOnTypeConvertedOrStringProperty);
        /// <summary>An attachable property named '{1}' is attached on a dictionary key '{0}' that is either a string or can be type-converted to string, which is not supported.</summary>
        internal const string AttachedPropertyOnDictionaryKey = nameof(AttachedPropertyOnDictionaryKey);
        /// <summary>Service provider is missing the IXamlNameProvider service.</summary>
        internal const string MissingNameProvider = nameof(MissingNameProvider);
        /// <summary>Cannot set SchemaContext on XamlMarkupExtensionWriter.</summary>
        internal const string XamlMarkupExtensionWriterCannotSetSchemaContext = nameof(XamlMarkupExtensionWriterCannotSetSchemaContext);
        /// <summary>The member '{0}' has already been written.</summary>
        internal const string XamlMarkupExtensionWriterDuplicateMember = nameof(XamlMarkupExtensionWriterDuplicateMember);
        /// <summary>Cannot write a value that is not a string.</summary>
        internal const string XamlMarkupExtensionWriterCannotWriteNonstringValue = nameof(XamlMarkupExtensionWriterCannotWriteNonstringValue);
        /// <summary>Errors detected in input.</summary>
        internal const string XamlMarkupExtensionWriterInputInvalid = nameof(XamlMarkupExtensionWriterInputInvalid);
        /// <summary>Failed to add attached properties to item in ConditionalWeakTable.</summary>
        internal const string DefaultAttachablePropertyStoreCannotAddInstance = nameof(DefaultAttachablePropertyStoreCannotAddInstance);
        /// <summary>Invalid metadata for attribute '{0}' on '{1}'. Expected '{2}' argument(s) of type '{3}'.</summary>
        internal const string UnexpectedConstructorArg = nameof(UnexpectedConstructorArg);
        /// <summary>Method '{0}' is not supported by default. It can be implemented in derived classes.</summary>
        internal const string ShouldOverrideMethod = nameof(ShouldOverrideMethod);
        /// <summary>Type name '{0}' is not assembly-qualified. You can obtain this value from System.Type.AssemblyQualifiedName.</summary>
        internal const string ExpectedQualifiedTypeName = nameof(ExpectedQualifiedTypeName);
        /// <summary>Assembly name '{0}' is not fully qualified. The Name, Version, Culture, and PublicKeyToken must all be provided.</summary>
        internal const string ExpectedQualifiedAssemblyName = nameof(ExpectedQualifiedAssemblyName);
        /// <summary>Expected permission of type XamlLoadPermission.</summary>
        internal const string ExpectedLoadPermission = nameof(ExpectedLoadPermission);
        /// <summary>Invalid security XML. Unexpected tag '{0}', expected '{1}'.</summary>
        internal const string SecurityXmlUnexpectedTag = nameof(SecurityXmlUnexpectedTag);
        /// <summary>Invalid security XML. Unexpected value '{0}' in attribute '{1}', expected '{2}'.</summary>
        internal const string SecurityXmlUnexpectedValue = nameof(SecurityXmlUnexpectedValue);
        /// <summary>Invalid security XML. Missing expected attribute '{0}'.</summary>
        internal const string SecurityXmlMissingAttribute = nameof(SecurityXmlMissingAttribute);
        /// <summary>The string is null or empty.</summary>
        internal const string StringIsNullOrEmpty = nameof(StringIsNullOrEmpty);
        /// <summary>This operation is not supported on unknown types.</summary>
        internal const string NotSupportedOnUnknownType = nameof(NotSupportedOnUnknownType);
        /// <summary>This operation is only supported on collection types.</summary>
        internal const string OnlySupportedOnCollections = nameof(OnlySupportedOnCollections);
        /// <summary>This operation is only supported on dictionary types.</summary>
        internal const string OnlySupportedOnDictionaries = nameof(OnlySupportedOnDictionaries);
        /// <summary>This operation is only supported on collection and dictionary types.</summary>
        internal const string OnlySupportedOnCollectionsAndDictionaries = nameof(OnlySupportedOnCollectionsAndDictionaries);
        /// <summary>This operation is not supported on unknown members.</summary>
        internal const string NotSupportedOnUnknownMember = nameof(NotSupportedOnUnknownMember);
        /// <summary>This operation is not supported on directive members.</summary>
        internal const string NotSupportedOnDirective = nameof(NotSupportedOnDirective);
        /// <summary>One of the following arguments must be non-null: '{0}'.</summary>
        internal const string ArgumentRequired = nameof(ArgumentRequired);
        /// <summary>Converter type '{0}' doesn't derive from expected base type '{1}'.</summary>
        internal const string ConverterMustDeriveFromBase = nameof(ConverterMustDeriveFromBase);
        /// <summary>Value cannot be null. Object reference: '{0}'.</summary>
        internal const string ReferenceIsNull = nameof(ReferenceIsNull);
        /// <summary>Must set Type before calling ProvideValue on ArrayExtension.</summary>
        internal const string MarkupExtensionArrayType = nameof(MarkupExtensionArrayType);
        /// <summary>Items in the array must be type '{0}'. One or more items cannot be cast to this type.</summary>
        internal const string MarkupExtensionArrayBadType = nameof(MarkupExtensionArrayBadType);
        /// <summary>'{0}' StaticExtension value cannot be resolved to an enumeration, static field, or static property.</summary>
        internal const string MarkupExtensionBadStatic = nameof(MarkupExtensionBadStatic);
        /// <summary>StaticExtension must have Member property set before ProvideValue can be called.</summary>
        internal const string MarkupExtensionStaticMember = nameof(MarkupExtensionStaticMember);
        /// <summary>'{0}' must be of type '{1}'.</summary>
        internal const string MustBeOfType = nameof(MustBeOfType);
        /// <summary>(null)</summary>
        internal const string ToStringNull = nameof(ToStringNull);
        /// <summary>'{0}' ValueSerializer cannot convert '{1}' to '{2}'.</summary>
        internal const string ConvertToException = nameof(ConvertToException);
        /// <summary>'{0}' ValueSerializer cannot convert from '{1}'.</summary>
        internal const string ConvertFromException = nameof(ConvertFromException);
        /// <summary>This serviceType is already registered to another service.</summary>
        internal const string ServiceTypeAlreadyAdded = nameof(ServiceTypeAlreadyAdded);
        /// <summary>'{0}' type name does not have the expected format 'className, assembly'.</summary>
        internal const string QualifiedNameHasWrongFormat = nameof(QualifiedNameHasWrongFormat);
        /// <summary>Too many attributes are specified for '{0}'.</summary>
        internal const string ParserAttributeArgsHigh = nameof(ParserAttributeArgsHigh);
        /// <summary>'{0}' requires more attributes.</summary>
        internal const string ParserAttributeArgsLow = nameof(ParserAttributeArgsLow);
        /// <summary>Cannot load assembly '{0}' because a different version of that same assembly is loaded '{1}'.</summary>
        internal const string ParserAssemblyLoadVersionMismatch = nameof(ParserAssemblyLoadVersionMismatch);
        /// <summary>Cannot promote from '{0}' to '{1}' because the target map is too small.</summary>
        internal const string FrugalList_TargetMapCannotHoldAllData = nameof(FrugalList_TargetMapCannotHoldAllData);
        /// <summary>Cannot promote from Array.</summary>
        internal const string FrugalList_CannotPromoteBeyondArray = nameof(FrugalList_CannotPromoteBeyondArray);
        /// <summary>A value in the '{0}' array is null.</summary>
        internal const string ValueInArrayIsNull = nameof(ValueInArrayIsNull);
        /// <summary>Event argument is invalid.</summary>
        internal const string InvalidEvent = nameof(InvalidEvent);
        /// <summary>Encountered a closing BracketCharacter '{0}' without a corresponding opening BracketCharacter.</summary>
        internal const string InvalidClosingBracketCharacers = nameof(InvalidClosingBracketCharacers);
        /// <summary>BracketCharacter '{0}' does not have a corresponding opening/closing BracketCharacter.</summary>
        internal const string MalformedBracketCharacters = nameof(MalformedBracketCharacters);

        public static string RoutedEventCannotChangeWhileRouting { get; } = nameof(RoutedEventCannotChangeWhileRouting);
        public static string RoutedEventArgsMustHaveRoutedEvent { get; } = nameof(RoutedEventArgsMustHaveRoutedEvent);
    }
}