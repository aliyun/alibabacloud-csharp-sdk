// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetOpsItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the O\&amp;M item.</para>
        /// </summary>
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public GetOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class GetOpsItemResponseBodyOpsItem : TeaModel {
            /// <summary>
            /// <para>The information about the attributes of the O\&amp;M item.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> Attributes { get; set; }

            /// <summary>
            /// <para>The category of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The user who created the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public string CreateBy { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10T06:15Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-update</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user who last modified the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modifiedBy</para>
            /// </summary>
            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// <para>The O\&amp;M item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oi-d52b08695e2b46ae8413</para>
            /// </summary>
            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            /// <summary>
            /// <para>The priority of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzxkofnlxtn2i</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Names (ARNs) of the associated resources.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            /// <summary>
            /// <para>The severity level of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Medium</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The solutions to the O\&amp;M item.</para>
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Solutions { get; set; }

            /// <summary>
            /// <para>The source business of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/aliyun/appManager</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags attached to the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;K1&quot;:&quot;V1&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The title of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10T06:15Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BED4C16-BD30-5E27-94D4-7EBCCECF70C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
