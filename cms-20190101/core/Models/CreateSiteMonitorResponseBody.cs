// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// <para>If a site monitoring task is created, the result is returned. If a site monitoring task fails to be created, no result is returned.</para>
        /// </summary>
        [NameInMap("CreateResultList")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyCreateResultList CreateResultList { get; set; }
        public class CreateSiteMonitorResponseBodyCreateResultList : TeaModel {
            [NameInMap("CreateResultList")]
            [Validation(Required=false)]
            public List<CreateSiteMonitorResponseBodyCreateResultListCreateResultList> CreateResultList { get; set; }
            public class CreateSiteMonitorResponseBodyCreateResultListCreateResultList : TeaModel {
                /// <summary>
                /// <para>The ID of the site monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2c8dbdf9-a3ab-46a1-85a4-f094965e****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The name of the site monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HanZhou_ECS1</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

        /// <summary>
        /// <para>The result of the site monitoring task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyData Data { get; set; }
        public class CreateSiteMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The result that is returned after you associate the existing alert rule with the site monitoring task.</para>
            /// </summary>
            [NameInMap("AttachAlertResult")]
            [Validation(Required=false)]
            public CreateSiteMonitorResponseBodyDataAttachAlertResult AttachAlertResult { get; set; }
            public class CreateSiteMonitorResponseBodyDataAttachAlertResult : TeaModel {
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public List<CreateSiteMonitorResponseBodyDataAttachAlertResultContact> Contact { get; set; }
                public class CreateSiteMonitorResponseBodyDataAttachAlertResultContact : TeaModel {
                    /// <summary>
                    /// <para>The status code that is returned after you associate the existing alert rule with the site monitoring task.</para>
                    /// <remarks>
                    /// <para> The status code 200 indicates that the request was successful.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The message that is returned after you associate the existing alert rule with the site monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>successful</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The ID of the request that was sent to associate the existing alert rule with the site monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5dd33455-4f65-4b0c-9200-33d66f3f340b</para>
                    /// </summary>
                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                    /// <summary>
                    /// <para>The ID of the alert rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SystemDefault_acs_ecs_dashboard_InternetOutRate_Percent</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the existing alert rule was associated with the site monitoring task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public string Success { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68192f5d-0d45-4b98-9724-892813f86c71</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
