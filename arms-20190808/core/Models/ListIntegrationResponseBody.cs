// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListIntegrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListIntegrationResponseBodyPageInfo PageInfo { get; set; }
        public class ListIntegrationResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The information about each alert integration.</para>
            /// </summary>
            [NameInMap("Integrations")]
            [Validation(Required=false)]
            public List<ListIntegrationResponseBodyPageInfoIntegrations> Integrations { get; set; }
            public class ListIntegrationResponseBodyPageInfoIntegrations : TeaModel {
                /// <summary>
                /// <para>The endpoint of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://alerts.aliyuncs.com/api/v1/integrations/custom/ymQBN">https://alerts.aliyuncs.com/api/v1/integrations/custom/ymQBN</a>******</para>
                /// </summary>
                [NameInMap("ApiEndpoint")]
                [Validation(Required=false)]
                public string ApiEndpoint { get; set; }

                /// <summary>
                /// <para>The time when the alert integration was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-18</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The information about the alert events.</para>
                /// </summary>
                [NameInMap("IntegrationDetail")]
                [Validation(Required=false)]
                public ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail IntegrationDetail { get; set; }
                public class ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether alert events are automatically cleared. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true (default)</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoRecover")]
                    [Validation(Required=false)]
                    public bool? AutoRecover { get; set; }

                    /// <summary>
                    /// <para>The description of the alert integration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The fields whose values are deduplicated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL.alertname::LABEL.severity</para>
                    /// </summary>
                    [NameInMap("DuplicateKey")]
                    [Validation(Required=false)]
                    public string DuplicateKey { get; set; }

                    /// <summary>
                    /// <para>The extended mapped fields of the alert source.</para>
                    /// </summary>
                    [NameInMap("ExtendedFieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> ExtendedFieldRedefineRules { get; set; }

                    /// <summary>
                    /// <para>The predefined mapped fields of the alert source.</para>
                    /// </summary>
                    [NameInMap("FieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> FieldRedefineRules { get; set; }

                    /// <summary>
                    /// <para>The field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.</para>
                    /// <remarks>
                    /// <para>Only the Log Service alert integration supports the parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.status</para>
                    /// </summary>
                    [NameInMap("InitiativeRecoverField")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverField { get; set; }

                    /// <summary>
                    /// <para>The value of the field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.</para>
                    /// <remarks>
                    /// <para>Only the Log Service alert integration supports the parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ok</para>
                    /// </summary>
                    [NameInMap("InitiativeRecoverValue")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverValue { get; set; }

                    /// <summary>
                    /// <para>The time when alert events are automatically cleared. Unit: seconds. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("RecoverTime")]
                    [Validation(Required=false)]
                    public long? RecoverTime { get; set; }

                    /// <summary>
                    /// <para>The total number of alert events and the number of abnormal alert events in the last hour.</para>
                    /// </summary>
                    [NameInMap("Stat")]
                    [Validation(Required=false)]
                    public List<long?> Stat { get; set; }

                }

                /// <summary>
                /// <para>The ID of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("IntegrationId")]
                [Validation(Required=false)]
                public long? IntegrationId { get; set; }

                /// <summary>
                /// <para>The name of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudMonitor integration</para>
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// <para>The type of the alert integration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CLOUD_MONITOR: CloudMonitor</description></item>
                /// <item><description>LOG_SERVICE: Log Service</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CLOUD_MONITOR</para>
                /// </summary>
                [NameInMap("IntegrationProductType")]
                [Validation(Required=false)]
                public string IntegrationProductType { get; set; }

                /// <summary>
                /// <para>The activity of the alert integration</para>
                /// 
                /// <b>Example:</b>
                /// <para>ready</para>
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// <para>The authentication token of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ymQBN******</para>
                /// </summary>
                [NameInMap("ShortToken")]
                [Validation(Required=false)]
                public string ShortToken { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert integration was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public bool? State { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of alert integrations returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of alert integrations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
