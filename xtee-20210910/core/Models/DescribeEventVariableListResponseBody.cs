// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventVariableListResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventVariableListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Action variable.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectActions> Actions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectActions : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deAddResult</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>决策结果</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTION</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Expression display. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3144</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input type of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameter. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input parameters. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>addDeResult</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Anomaly value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>决策结果</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectActionsVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Device variable.</para>
            /// </summary>
            [NameInMap("deviceVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectDeviceVariables> DeviceVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectDeviceVariables : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queryPhoneSimulatorInfo(deviceToken)?.deviceName</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>设备信息-设备名称</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and grouping label.</para>
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
                /// <para>The detailed information of the field in the field pool. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field rank.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The source of the field. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
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
                /// <para>Input for the variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
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
                    /// <para>The minimum value.</para>
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
                /// <para>Parent node. This field is not returned for this type of variable.</para>
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
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>设备信息-设备名称-deviceName</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
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
                    /// <para>The IV value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Custom variable.</para>
            /// </summary>
            [NameInMap("expressionVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectExpressionVariables> ExpressionVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectExpressionVariables : TeaModel {
                /// <summary>
                /// <para>The code of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deInvokeSelfVariable(390397)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The definition ID of the variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前7位</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and grouping label.</para>
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
                /// <para>The detailed information of the field in the field pool. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field rank.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The source of the field. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The input type of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
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
                /// <para>Multiple input parameters separated by commas. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The name of the variable.</para>
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
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前7位</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the variable.</para>
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
                    /// <para>The IV value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Favorite variables.</para>
            /// </summary>
            [NameInMap("favoriteVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectFavoriteVariables> FavoriteVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariables : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deFunctionProcess(ip,\&quot;isIp\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>判断是否符合IPv4标准</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Expression display value. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BOOLEAN</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input parameters should be separated by commas. Some variables may not have this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>isIpAddressV4</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Anomaly value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP是否符合IPV4格式</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectFavoriteVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Intermediate variable return object.</para>
            /// </summary>
            [NameInMap("middleVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectMiddleVariables> MiddleVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectMiddleVariables : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mid</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>register</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIDDLE</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Calculate the display value of the expression. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Variable source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input field type, indicating the type of input parameters, mainly used for function classification. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mid</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>midVaribale</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIDDLE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This type of variable does not return this field.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectMiddleVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>id value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>An array of model variables.</para>
            /// </summary>
            [NameInMap("modelVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectModelVariables> ModelVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectModelVariables : TeaModel {
                /// <summary>
                /// <para>The code of the model variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getAIData(model)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The definition ID of the model variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description of the model variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BL_t_show</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and grouping label.</para>
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
                /// <para>The detailed information of the field in the field pool. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field rank.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The source of the field. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The type of the field.</para>
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
                /// <para>Multiple input parameters separated by commas. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The name of the model variable.</para>
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
                /// <para>The title of the model variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BL_t_show</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the model variable.</para>
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
                    /// <para>The IV value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>List of name variables.</para>
            /// </summary>
            [NameInMap("nameList")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNameList> NameList { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNameList : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nl_UN8otElLb490</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not currently returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAME_LIST</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Calculate the expression display value. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input parameters. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nl_UN8otElLb490</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned currently.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>白名单</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAME_LIST</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNameListVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>List of available functions for the original variable.</para>
            /// </summary>
            [NameInMap("nativeVariableFunctions")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions> NativeVariableFunctions { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctions : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getHourOfTimestamp({data})</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>时间戳，可以是秒或者毫秒</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUNC</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Calculate the expression display value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Variable return type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LONG</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
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
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>getHourOfTimestamp</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Exception value. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Variable title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据时间戳获取小时</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUNC</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This type of variable does not return this field.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariableFunctionsVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>List of event fields.</para>
            /// </summary>
            [NameInMap("nativeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectNativeVariables> NativeVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectNativeVariables : TeaModel {
                /// <summary>
                /// <para>variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Associated variable definition ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>register</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Calculate expression display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite Identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Field pool field details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field Sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Variable source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFINE</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>223</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input field type, indicating the type of input parameters, mainly used for function categorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input of the variable. Event field is not present.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>outlier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output score threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>parentName</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Variable source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable indicator information.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectNativeVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>y</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>An array of custom query variables.</para>
            /// </summary>
            [NameInMap("queryVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectQueryVariables> QueryVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectQueryVariables : TeaModel {
                /// <summary>
                /// <para>The code of the query variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deInvokeQueryVariable(376773)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The definition ID of the query variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description of the query variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄计算</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and grouping label.</para>
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
                /// <para>The detailed information of the field in the field pool. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field rank.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The source of the field. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The type of the field.</para>
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
                /// <para>Multiple input parameters separated by commas. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The name of the query variable.</para>
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
                /// <para>The title of the query variable. The title of the query variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄计算</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the query variable.</para>
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
                    /// <para>The IV value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Custom variables (custom variables, cumulative variables, custom system variables).</para>
            /// </summary>
            [NameInMap("selfVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSelfVariables> SelfVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSelfVariables : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deReadVelocity(hitRules,\&quot;dUd5ioJ8014\&quot;,1,\&quot;MO\&quot;,0,true,\&quot;SUM\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Variable definition ID. Only returned for custom system variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>变量的描述信息</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Expression name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>@IP地址</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Variable ID.</para>
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
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input parameters. Only returned when custom system variables are defined.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_isvspbF2c7ac</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Anomaly value. Returned when the variable is a custom variable (type= EXPRESSION).</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent node. This field is not returned currently.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取手机号前七位</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPRESSION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSelfVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>System variables.</para>
            /// </summary>
            [NameInMap("sysVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectSysVariables> SysVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectSysVariables : TeaModel {
                /// <summary>
                /// <para>Variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>parseIpV2(ip)?.cityId</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>ID of the bound variable definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2488</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>Description of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通过IP地址库解析IP所在的城市Code，例如，输入“42.120.74.211”，经过该变量运算，输出“330100”。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display type and group label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("displayType")]
                [Validation(Required=false)]
                public string DisplayType { get; set; }

                /// <summary>
                /// <para>Calculate the expression display value. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("expressionTitle")]
                [Validation(Required=false)]
                public string ExpressionTitle { get; set; }

                /// <summary>
                /// <para>Favorite identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("favoriteFlag")]
                [Validation(Required=false)]
                public bool? FavoriteFlag { get; set; }

                /// <summary>
                /// <para>Details of the field pool. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>Field sorting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>Source of the field. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3151</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Input type of the parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputFieldType")]
                [Validation(Required=false)]
                public string InputFieldType { get; set; }

                /// <summary>
                /// <para>Required parameter. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Variable value input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>ipLocationCityCode</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Outlier value. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("outlier")]
                [Validation(Required=false)]
                public string Outlier { get; set; }

                /// <summary>
                /// <para>Output value threshold.</para>
                /// </summary>
                [NameInMap("outputThreshold")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold OutputThreshold { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesOutputThreshold : TeaModel {
                    /// <summary>
                    /// <para>Maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public double? MaxValue { get; set; }

                    /// <summary>
                    /// <para>Minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public double? MinValue { get; set; }

                }

                /// <summary>
                /// <para>Parent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("parentName")]
                [Validation(Required=false)]
                public string ParentName { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP所在地_城市Code</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_BIND</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Variable metric information. This field is not returned for this type of variable.</para>
                /// </summary>
                [NameInMap("variableVelocity")]
                [Validation(Required=false)]
                public DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity VariableVelocity { get; set; }
                public class DescribeEventVariableListResponseBodyResultObjectSysVariablesVariableVelocity : TeaModel {
                    /// <summary>
                    /// <para>iv value. This type of variable does not return this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>x label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>y label. This type of variable does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

            /// <summary>
            /// <para>Other related variables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("thirdVariables")]
            [Validation(Required=false)]
            public Dictionary<string, object> ThirdVariables { get; set; }

            /// <summary>
            /// <para>An array of accumulated variables.</para>
            /// </summary>
            [NameInMap("velocityVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableListResponseBodyResultObjectVelocityVariables> VelocityVariables { get; set; }
            public class DescribeEventVariableListResponseBodyResultObjectVelocityVariables : TeaModel {
                /// <summary>
                /// <para>The code of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deReadVelocity(userId,\&quot;hFsEFUEe88a\&quot;,1,\&quot;H\&quot;,0,true,\&quot;COUNT\&quot;)</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The definition ID of the variable. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("defineId")]
                [Validation(Required=false)]
                public string DefineId { get; set; }

                /// <summary>
                /// <para>The description of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>累计用户省份次数。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display type and grouping label.</para>
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
                /// <para>The detailed information of the field in the field pool. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldDetail")]
                [Validation(Required=false)]
                public string FieldDetail { get; set; }

                /// <summary>
                /// <para>The field rank.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public int? FieldRank { get; set; }

                /// <summary>
                /// <para>The source of the field. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>The type of the field.</para>
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
                /// <para>Multiple input parameters separated by commas. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The name of the variable.</para>
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
                /// <para>The title of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>累计用户省份次数</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the variable.</para>
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
                    /// <para>The IV value. This field is not returned for this type of variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This type does not have this field</para>
                    /// </summary>
                    [NameInMap("iv")]
                    [Validation(Required=false)]
                    public string Iv { get; set; }

                }

                /// <summary>
                /// <para>The X label. This field is not returned for this type of variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This type does not have this field</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y label. This field is not returned for this type of variable.</para>
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
