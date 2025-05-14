// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListErsResponseBodyContent Content { get; set; }
        public class ListErsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>lingjun hub information list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListErsResponseBodyContentData> Data { get; set; }
            public class ListErsResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The number of connections to the Lingjun HUB network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// <para>The time when the activation code was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640930671000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the Lingjun HUB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>The name of the Lingjun HUB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-wulanchabu-main</para>
                /// </summary>
                [NameInMap("ErName")]
                [Validation(Required=false)]
                public string ErName { get; set; }

                /// <summary>
                /// <para>The time when the O\&amp;M task was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640930671000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The primary zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu-b</para>
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmv2m2w43japa</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Number of Lingjun HUB routing policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RouteMaps")]
                [Validation(Required=false)]
                public long? RouteMaps { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListErsResponseBodyContentDataTags> Tags { get; set; }
                public class ListErsResponseBodyContentDataTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655449505171</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is displayed.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC8C713A-A9F4-5984-A5E1-76496DF35153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
