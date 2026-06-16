// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventVariableListResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventVariableListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The action variables.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectActions> Actions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectActions : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deAddResult</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>决策结果</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTION</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The expression display. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3144</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>addDeResult</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>决策结果</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The device variables.</para>
            /// </summary>
            [NameInMap("deviceVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectDeviceVariables> DeviceVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectDeviceVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queryPhoneSimulatorInfo(deviceToken)?.deviceName</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>设备信息-设备名称</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEVICE</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input of the variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>device_name</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectDeviceVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectDeviceVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>设备信息-设备名称-deviceName</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEVICE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectDeviceVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectDeviceVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The custom variables.</para>
            /// </summary>
            [NameInMap("expressionVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectExpressionVariables> ExpressionVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectExpressionVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deInvokeSelfVariable(390397)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前7位</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPRESSION</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>@testaaa +1</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The variable input type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3148</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters, separated by commas if multiple. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_w2yIClHCc150</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectExpressionVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectExpressionVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前7位</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPRESSION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectExpressionVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectExpressionVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The favorite variables.</para>
            /// </summary>
            [NameInMap("favoriteVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectFavoriteVariables> FavoriteVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deFunctionProcess(ip,\&quot;isIp\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>判断是否符合IPv4标准</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The expression display value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BOOLEAN</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters, separated by commas if multiple. Some variables do not have this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>isIpAddressV4</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP是否符合IPV4格式</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The intermediate variable response object.</para>
            /// </summary>
            [NameInMap("middleVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectMiddleVariables> MiddleVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectMiddleVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mid</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>register</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIDDLE</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The variable source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input field type, which indicates the input parameter type and is mainly used for function classification. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mid</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>midVaribale</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIDDLE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The ID value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The model variables.</para>
            /// </summary>
            [NameInMap("modelVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectModelVariables> ModelVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectModelVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getAIData(model)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BL_t_show</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MODEL</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOUBLE</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID of the model variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters, separated by commas if multiple. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mo_qbbyf33o66f2</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectModelVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectModelVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BL_t_show</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MODEL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectModelVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectModelVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The list variables.</para>
            /// </summary>
            [NameInMap("nameList")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNameList> NameList { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNameList : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nl_UN8otElLb490</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not currently returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAME_LIST</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nl_UN8otElLb490</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not currently returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>白名单</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAME_LIST</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The list of available functions for native variables.</para>
            /// </summary>
            [NameInMap("nativeVariableFunctions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions> NativeVariableFunctions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getHourOfTimestamp({data})</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>时间戳，可以是秒或者毫秒</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUNC</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The variable return value type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LONG</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>93</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATE</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input fields. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>getHourOfTimestamp</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The variable title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据时间戳获取小时</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUNC</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The list of event fields.</para>
            /// </summary>
            [NameInMap("nativeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariables> NativeVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The associated variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>register</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The variable source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFINE</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>223</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input field type, which indicates the input parameter type and is mainly used for function classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input of the variable. This field is not returned for event fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output score threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>parentName</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The variable source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>y</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The custom query variables.</para>
            /// </summary>
            [NameInMap("queryVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectQueryVariables> QueryVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectQueryVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deInvokeQueryVariable(376773)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄计算</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUERY_EXPRESSION</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT  AVG( $source )\nFROM testCase\nWHERE  $age &gt; 0</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID of the query variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3148</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters, separated by commas if multiple. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_qWtKgCox350f</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYS_ERROR</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectQueryVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectQueryVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_SOURCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄计算</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUERY_EXPRESSION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectQueryVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectQueryVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The custom variables (custom variables, cumulative variables, and custom system variables).</para>
            /// </summary>
            [NameInMap("selfVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSelfVariables> SelfVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSelfVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deReadVelocity(hitRules,\&quot;dUd5ioJ8014\&quot;,1,\&quot;MO\&quot;,0,true,\&quot;SUM\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is returned only for custom system variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>变量的描述信息</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The expression name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>@IP地址</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3174</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters. This field is returned only for custom system variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_isvspbF2c7ac</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is returned when the variable is a custom variable (type=EXPRESSION).</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not currently returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前七位</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPRESSION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The system variables.</para>
            /// </summary>
            [NameInMap("sysVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSysVariables> SysVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSysVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>parseIpV2(ip)?.cityId</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The bound variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2488</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通过IP地址库解析IP所在的城市Code，例如，输入“42.120.74.211”，经过该变量运算，输出“330100”。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3151</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The variable value input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>ipLocationCityCode</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP所在地_城市Code</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>The other variables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("thirdVariables")]
            [Validation(Required=false)]
            public Dictionary<string, object> ThirdVariables { get; set; }

            /// <summary>
            /// <para>The custom cumulative variables.</para>
            /// </summary>
            [NameInMap("velocityVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectVelocityVariables> VelocityVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectVelocityVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deReadVelocity(userId,\&quot;hFsEFUEe88a\&quot;,1,\&quot;H\&quot;,0,true,\&quot;COUNT\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The variable definition ID. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>累计用户省份次数。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_VELOCITY</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>The display value of the calculation expression. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>The favorite flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>The field pool field details. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field sort order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The field source. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOUBLE</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3148</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>The required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters, separated by commas if multiple. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hFsEFUEe88a</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>The output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectVelocityVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectVelocityVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>The parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF_SELF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>累计用户省份次数</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_VELOCITY</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectVelocityVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectVelocityVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>The information value (IV). This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The X-axis label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

        }

    }

}
