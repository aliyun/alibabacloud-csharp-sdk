// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventVariableListResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventVariableListResponseBodyResultObject : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectActions> Actions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectActions : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("deviceVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectDeviceVariables> DeviceVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectDeviceVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectDeviceVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectDeviceVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectDeviceVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectDeviceVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("expressionVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectExpressionVariables> ExpressionVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectExpressionVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectExpressionVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectExpressionVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectExpressionVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectExpressionVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("favoriteVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectFavoriteVariables> FavoriteVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("middleVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectMiddleVariables> MiddleVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectMiddleVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("modelVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectModelVariables> ModelVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectModelVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectModelVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectModelVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectModelVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectModelVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("nameList")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNameList> NameList { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNameList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("nativeVariableFunctions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions> NativeVariableFunctions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("nativeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariables> NativeVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("queryVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectQueryVariables> QueryVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectQueryVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectQueryVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectQueryVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectQueryVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectQueryVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("selfVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSelfVariables> SelfVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSelfVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("sysVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSysVariables> SysVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSysVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            [NameInMap("thirdVariables")]
            [Validation(Required=false)]
            public Dictionary<string, object> ThirdVariables { get; set; }

            [NameInMap("velocityVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectVelocityVariables> VelocityVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectVelocityVariables : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectVelocityVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectVelocityVariablesOutputThreshold : TeaModel {
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectVelocityVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectVelocityVariablesVariableVelocity : TeaModel {
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

        }

    }

}
