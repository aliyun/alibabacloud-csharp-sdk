// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The configurations of application alerts.</para>
            /// </summary>
            [NameInMap("AlarmConfig")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyApplicationAlarmConfig AlarmConfig { get; set; }
            public class GetApplicationResponseBodyApplicationAlarmConfig : TeaModel {
                /// <summary>
                /// <para>The alert contact list.</para>
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public List<string> ContactGroups { get; set; }

                /// <summary>
                /// <para>The health check URL of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/health/</para>
                /// </summary>
                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                /// <summary>
                /// <para>The ID of the alert template.</para>
                /// </summary>
                [NameInMap("TemplateIds")]
                [Validation(Required=false)]
                public List<string> TemplateIds { get; set; }

            }

            /// <summary>
            /// <para>The type of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ComputeNest</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Custom</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>DingTalk</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T09:17:46Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyApplication</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-79538e30e44541b699d8</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;: &quot;v1&quot;, &quot;k2&quot;: &quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The time when the application was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T09:17:46Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51004B8A-6D9A-5ACB-9158-6C6794496AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
