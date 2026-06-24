// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the anomalous activity.</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public DescribeEventDetailResponseBodyEvent Event { get; set; }
        public class DescribeEventDetailResponseBodyEvent : TeaModel {
            /// <summary>
            /// <para>The time when the alert for the anomalous activity was triggered. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545829129000</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the detection of the anomalous activity is enhanced. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Enhancing the detection of anomalous activities improves detection accuracy and the alert reporting rate.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }

            /// <summary>
            /// <para>The name of the asset instance in which the anomalous activity occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in-222***</para>
            /// </summary>
            [NameInMap("DataInstance")]
            [Validation(Required=false)]
            public string DataInstance { get; set; }

            /// <summary>
            /// <para>The display name of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundunsr</para>
            /// </summary>
            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }

            /// <summary>
            /// <para>The logon name of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }

            /// <summary>
            /// <para>The reason for handling the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anomaly confirmed</para>
            /// </summary>
            [NameInMap("DealReason")]
            [Validation(Required=false)]
            public string DealReason { get; set; }

            /// <summary>
            /// <para>The time when the anomalous activity was handled. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611139155000</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// <para>The ID of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>229157443385014***</para>
            /// </summary>
            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }

            /// <summary>
            /// <para>The specific content of the anomalous activity details.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeEventDetailResponseBodyEventDetail Detail { get; set; }
            public class DescribeEventDetailResponseBodyEventDetail : TeaModel {
                /// <summary>
                /// <para>The baseline behavior profile for the anomalous activity.</para>
                /// </summary>
                [NameInMap("Chart")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailChart> Chart { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailChart : TeaModel {
                    /// <summary>
                    /// <para>The type of the chart. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>1</b>: column chart.</para>
                    /// </description></item>
                    /// <item><description><para><b>2</b>: line chart.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>This parameter is returned only when NewAlarm is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ChatType")]
                    [Validation(Required=false)]
                    public int? ChatType { get; set; }

                    /// <summary>
                    /// <para>The data items of the baseline behavior profile for the anomalous activity.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public DescribeEventDetailResponseBodyEventDetailChartData Data { get; set; }
                    public class DescribeEventDetailResponseBodyEventDetailChartData : TeaModel {
                        /// <summary>
                        /// <para>The values of the data items on the x-axis.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[test1,test2,...]</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public List<string> X { get; set; }

                        /// <summary>
                        /// <para>The values of the data items on the y-axis.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[1,2,3,...]</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public List<string> Y { get; set; }

                        /// <summary>
                        /// <para>The values of the data items on the z-axis.</para>
                        /// </summary>
                        [NameInMap("Z")]
                        [Validation(Required=false)]
                        public List<string> Z { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the baseline behavior profile for the anomalous activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Baseline behavior chart</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The title of the chart.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only when NewAlarm is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>misskingm</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the chart. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>1</b>: column chart.</para>
                    /// </description></item>
                    /// <item><description><para><b>2</b>: line chart.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The label of the x-axis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of days</para>
                    /// </summary>
                    [NameInMap("XLabel")]
                    [Validation(Required=false)]
                    public string XLabel { get; set; }

                    /// <summary>
                    /// <para>The label of the y-axis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Value</para>
                    /// </summary>
                    [NameInMap("YLabel")]
                    [Validation(Required=false)]
                    public string YLabel { get; set; }

                    /// <summary>
                    /// <para>The label of the z-axis.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only when NewAlarm is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chart description</para>
                    /// </summary>
                    [NameInMap("ZLabel")]
                    [Validation(Required=false)]
                    public string ZLabel { get; set; }

                }

                /// <summary>
                /// <para>The content of the anomalous activity.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailContent> Content { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailContent : TeaModel {
                    /// <summary>
                    /// <para>The title of the anomalous activity content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Anomaly description</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The name of the anomalous activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>daliaoyuncom</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The description of the anomalous activity content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The account was used to access OSS from an unusual terminal whose IP address is 1.2.3.4 from 00:06:45 on September 9, 2019 to 00:57:37 on September 9, 2019.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The information about the source of the anomalous activity.</para>
                /// </summary>
                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailResourceInfo> ResourceInfo { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The title of the source of the anomalous activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Risk</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The description of the source of the anomalous activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Based on the record of authentication by using an unusual terminal, an attacker may have obtained the access permission of the account, or an employee accessed data from a personal terminal.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The display name of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundunsr</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the anomalous activity occurred. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545829129000</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// <para>The handling history.</para>
            /// </summary>
            [NameInMap("HandleInfoList")]
            [Validation(Required=false)]
            public List<DescribeEventDetailResponseBodyEventHandleInfoList> HandleInfoList { get; set; }
            public class DescribeEventDetailResponseBodyEventHandleInfoList : TeaModel {
                /// <summary>
                /// <para>Specifies the account that handled the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sddp-test2</para>
                /// </summary>
                [NameInMap("CurrentValue")]
                [Validation(Required=false)]
                public string CurrentValue { get; set; }

                /// <summary>
                /// <para>The time when the handling action was disabled. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611139155000</para>
                /// </summary>
                [NameInMap("DisableTime")]
                [Validation(Required=false)]
                public long? DisableTime { get; set; }

                /// <summary>
                /// <para>The time when the handling action was enabled. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611139155000</para>
                /// </summary>
                [NameInMap("EnableTime")]
                [Validation(Required=false)]
                public long? EnableTime { get; set; }

                /// <summary>
                /// <para>The handling method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remove from the whitelist</para>
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// <para>The handling type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds_security_ip</para>
                /// </summary>
                [NameInMap("HandlerType")]
                [Validation(Required=false)]
                public string HandlerType { get; set; }

                /// <summary>
                /// <para>The duration of the handling action. Unit: minutes. If this parameter is empty, the handling action is permanent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("HandlerValue")]
                [Validation(Required=false)]
                public int? HandlerValue { get; set; }

                /// <summary>
                /// <para>The handling ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The status of the handling action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: disabled.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>-1</b>: disabling failed.</para>
                /// </description></item>
                /// <item><description><para><b>-2</b>: enabling failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the anomalous activity that is recorded in Data Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The details of the alert log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;client_ip&quot;: [&quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;, &quot;106.11.XX.XX&quot;], &quot;start_time&quot;: &quot;2020-05-10 00:00:01&quot;, &quot;instance&quot;: [&quot;omniscience-data&quot;, &quot;punish-beaver-data&quot;], &quot;end_time&quot;: &quot;2020-05-10 00:21:22&quot;, &quot;client_ua&quot;: [&quot;Java/1.8.0_152&quot;, &quot;Java/1.8.0_92&quot;, &quot;aliyun-sdk-java/2.0.0&quot;, &quot;aliyun-sdk-java/2.8.0(Linux/4.9.151-015.ali3000.alios7.x86_64/amd64;1.8.0_152)&quot;], &quot;user_name&quot;: 1512222261295262}</para>
            /// </summary>
            [NameInMap("LogDetail")]
            [Validation(Required=false)]
            public string LogDetail { get; set; }

            /// <summary>
            /// <para>The name of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert is of the new version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NewAlarm")]
            [Validation(Required=false)]
            public bool? NewAlarm { get; set; }

            /// <summary>
            /// <para>The name of the product in which the anomalous activity is detected. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The processing status of the anomalous activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: unhandled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: dismissed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The name of the processing status of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// <para>The code of the anomalous activity subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>020008</para>
            /// </summary>
            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }

            /// <summary>
            /// <para>The name of the anomalous activity subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anomalous volume of downloaded data</para>
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

            /// <summary>
            /// <para>The code of the anomalous activity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            /// <summary>
            /// <para>The name of the anomalous activity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>01</b>: anomalous permission access.</para>
            /// </description></item>
            /// <item><description><para><b>02</b>: anomalous data flow.</para>
            /// </description></item>
            /// <item><description><para><b>03</b>: anomalous data operation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Anomalous data flow</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// <para>The ID of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>229157443385014***</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
