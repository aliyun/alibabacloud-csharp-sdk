// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The help information about the check item.</para>
        /// </summary>
        [NameInMap("AssistInfo")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyAssistInfo AssistInfo { get; set; }
        public class GetCheckDetailResponseBodyAssistInfo : TeaModel {
            /// <summary>
            /// <para>The link to the help information about the risk item when the Type parameter is set to link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibabacloud.com/help/en/resource-access-management/latest/faq-about-ram-users">https://www.alibabacloud.com/help/en/resource-access-management/latest/faq-about-ram-users</a></para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The type of the help information about the risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b></description></item>
            /// <item><description><b>link</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content in the help information about the risk item when the Type parameter is set to text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Configure an IP address whitelist</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The custom configuration items of the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<GetCheckDetailResponseBodyCustomConfigs> CustomConfigs { get; set; }
        public class GetCheckDetailResponseBodyCustomConfigs : TeaModel {
            /// <summary>
            /// <para>The default value of the custom configuration item. The value is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The name of the custom configuration item, which is unique in a check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionTimeMax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The display name of the custom configuration item for internationalization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum session time</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The type of the custom configuration item. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;:\&quot;NUMBER\&quot;,\&quot;range\&quot;:[1,24]}</para>
            /// </summary>
            [NameInMap("TypeDefine")]
            [Validation(Required=false)]
            public string TypeDefine { get; set; }

            /// <summary>
            /// <para>The value of the custom configuration item. The value is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the check item.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyDescription Description { get; set; }
        public class GetCheckDetailResponseBodyDescription : TeaModel {
            /// <summary>
            /// <para>The link to the description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibabacloud.com/help/en/object-storage-service/latest/tutorial-implement-data-sharing-across-departments-based-on-bucket-policies">https://www.alibabacloud.com/help/en/object-storage-service/latest/tutorial-implement-data-sharing-across-departments-based-on-bucket-policies</a></para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The description type of the check item. The value is fixed as text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content in the description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The MSE instance does not enable authentication by default. If public network access is enabled at the same time, the data in the configuration center may be dragged and there is a security risk.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RepairReset")]
        [Validation(Required=false)]
        [Obsolete]
        public string RepairReset { get; set; }

        /// <summary>
        /// <para>The fixing parameter configurations of the check item.</para>
        /// </summary>
        [NameInMap("RepairSetting")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyRepairSetting RepairSetting { get; set; }
        public class GetCheckDetailResponseBodyRepairSetting : TeaModel {
            /// <summary>
            /// <para>The description of the fixing workflow.</para>
            /// </summary>
            [NameInMap("FlowStep")]
            [Validation(Required=false)]
            public List<GetCheckDetailResponseBodyRepairSettingFlowStep> FlowStep { get; set; }
            public class GetCheckDetailResponseBodyRepairSettingFlowStep : TeaModel {
                /// <summary>
                /// <para>The text description of the fixing step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The first step is to open the calling interface.</para>
                /// </summary>
                [NameInMap("ShowText")]
                [Validation(Required=false)]
                public string ShowText { get; set; }

                /// <summary>
                /// <para>The sequence number of the fixing step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the fixing parameters.</para>
            /// </summary>
            [NameInMap("RepairConfigs")]
            [Validation(Required=false)]
            public List<GetCheckDetailResponseBodyRepairSettingRepairConfigs> RepairConfigs { get; set; }
            public class GetCheckDetailResponseBodyRepairSettingRepairConfigs : TeaModel {
                /// <summary>
                /// <para>Indicates whether the value of the parameter is displayed in the console. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The historical value and real-time value of the parameter are displayed.</description></item>
                /// <item><description>1: Only the real-time value of the parameter is displayed.</description></item>
                /// <item><description>2: The value of the parameter is not displayed in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConsoleParamType")]
                [Validation(Required=false)]
                public string ConsoleParamType { get; set; }

                /// <summary>
                /// <para>Indicates whether custom configurations of the fixing parameters are supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CustomFlag")]
                [Validation(Required=false)]
                public bool? CustomFlag { get; set; }

                /// <summary>
                /// <para>Indicates whether data needs to be encrypted during transmission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Data does not need to be encrypted during transmission.</description></item>
                /// <item><description>1: Data needs to be encrypted during transmission.</description></item>
                /// <item><description>2: Data needs to be encrypted during transmission, and the user must perform secondary confirmation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DataTransformType")]
                [Validation(Required=false)]
                public string DataTransformType { get; set; }

                /// <summary>
                /// <para>The default value of the parameter. The value is a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Indicates whether this parameter is specified by the user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The default value is used.</description></item>
                /// <item><description>1: This parameter is required, and no default value is specified.</description></item>
                /// <item><description>2: This parameter can be left empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EmptyParamSwitch")]
                [Validation(Required=false)]
                public string EmptyParamSwitch { get; set; }

                /// <summary>
                /// <para>The fixing parameters that are not compatible with this parameter.</para>
                /// </summary>
                [NameInMap("ExclusiveName")]
                [Validation(Required=false)]
                public List<string> ExclusiveName { get; set; }

                /// <summary>
                /// <para>The ID of the fixing workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64312d3ee19d470a9b54393dab****</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The name of the parameter. The name must be unique within the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>navicat</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>port</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the parameter. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;NUMBER\&quot;,\&quot;range\&quot;:[1,24]}</para>
                /// </summary>
                [NameInMap("TypeDefine")]
                [Validation(Required=false)]
                public string TypeDefine { get; set; }

                /// <summary>
                /// <para>The type of the parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: asset parameters that are required during fixing.</description></item>
                /// <item><description>2: user-provided parameters that are required during fixing.</description></item>
                /// <item><description>3: parameters that are temporarily provided by the user.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsageType")]
                [Validation(Required=false)]
                public string UsageType { get; set; }

                /// <summary>
                /// <para>The user-configured value of the parameter. The value is a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a restart is required after the fixing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RepairReset")]
            [Validation(Required=false)]
            public bool? RepairReset { get; set; }

            /// <summary>
            /// <para>Indicates whether the check item supports the quick fix feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RepairSupport")]
            [Validation(Required=false)]
            public bool? RepairSupport { get; set; }

            /// <summary>
            /// <para>The fixing type that is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The fixing and rollback are supported.</description></item>
            /// <item><description><b>2</b>: The fixing is supported, but the rollback is not supported.</description></item>
            /// <item><description><b>3</b>: The fixing must be performed on a third-party platform.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepairSupportType")]
            [Validation(Required=false)]
            public int? RepairSupportType { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RepairSupportType")]
        [Validation(Required=false)]
        [Obsolete]
        public int? RepairSupportType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15A6ED6A-DBFE-5255-A248-289907809BEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The solution to handle the risk item.</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodySolution Solution { get; set; }
        public class GetCheckDetailResponseBodySolution : TeaModel {
            /// <summary>
            /// <para>The link to the solution to handle the risk item when the Type parameter is set to link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibabacloud.com/help/en/object-storage-service/latest/tutorial-implement-data-sharing-across-departments-based-on-bucket-policies">https://www.alibabacloud.com/help/en/object-storage-service/latest/tutorial-implement-data-sharing-across-departments-based-on-bucket-policies</a></para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The type of the solution to handle the risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b></description></item>
            /// <item><description><b>link</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content of the solution to handle the risk item when the Type parameter is set to text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enter the MSE product console - registration and configuration center - instance list, click the corresponding instance name to enter the instance details, find the public network whitelist setting option in the basic information, and configure the whitelist according to business needs. It is forbidden to configure 0.0.0.0 or the whitelist as null.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
