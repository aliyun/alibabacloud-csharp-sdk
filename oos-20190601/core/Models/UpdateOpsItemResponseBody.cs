// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateOpsItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the O\&amp;M item.</para>
        /// </summary>
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public UpdateOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class UpdateOpsItemResponseBodyOpsItem : TeaModel {
            /// <summary>
            /// <para>The attributes of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Attribute\&quot;: {\&quot;Weight\&quot;: 100}, \&quot;RealServer\&quot;: \&quot;uaejc8hnqzqz5valyh8dibolpvza48ik.yundunwaf5.com\&quot;}]</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>The category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-16T07:04Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The user who created the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

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
            /// <para>The user who modified the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oi-e2264dcf040c472598e9</para>
            /// </summary>
            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ARNs of the associated resources.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            /// <summary>
            /// <para>The severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Medium</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The solutions.</para>
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<string> Solutions { get; set; }

            /// <summary>
            /// <para>The source business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/aliyun/ecs</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;k1&quot;: &quot;v1&quot;,
            ///       &quot;k2&quot;: &quot;v2&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The title of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-16T08:04Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C996DECB-3D2B-5321-B359-BE7031B6399E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
