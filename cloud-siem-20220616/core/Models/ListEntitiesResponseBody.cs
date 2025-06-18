// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEntitiesResponseBodyData Data { get; set; }
        public class ListEntitiesResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListEntitiesResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListEntitiesResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListEntitiesResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListEntitiesResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456789****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;file_path&quot;: &quot;c:/www/leixi.jsp&quot;,&quot;file_hash&quot;: &quot;aa0ca926ad948cd820e0a3d9a18c****&quot;,&quot;host_uuid&quot;: &quot;efed2cf7-0b77-45d9-a97b-d2cf246b****&quot;,&quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;,&quot;host_name&quot;: &quot;launch-advisor-2023****&quot;}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public string EntityInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123.123.123.123</para>
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8087b3e4aa6862852c100c8738cf****</para>
                /// </summary>
                [NameInMap("EntityUuid")]
                [Validation(Required=false)]
                public string EntityUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EventNum")]
                [Validation(Required=false)]
                public int? EventNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456789***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("IsAsset")]
                [Validation(Required=false)]
                public string IsAsset { get; set; }

                [NameInMap("IsMalware")]
                [Validation(Required=false)]
                public string IsMalware { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun.siem.sas.alert_tag.webshell</para>
                /// </summary>
                [NameInMap("MalwareType")]
                [Validation(Required=false)]
                public string MalwareType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>113091674488****</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
