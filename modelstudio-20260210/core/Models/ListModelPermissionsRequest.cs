// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The authorization query dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTHORIZED</b>: models that have been authorized for the specified modelAction. Use this value together with modelAction.</description></item>
        /// <item><description><b>AUTHORIZABLE</b>: full authorizable catalog.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTHORIZABLE</para>
        /// </summary>
        [NameInMap("authorizationScope")]
        [Validation(Required=false)]
        public string AuthorizationScope { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public ListModelPermissionsRequestFilter Filter { get; set; }
        public class ListModelPermissionsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The exact match for a single model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The fuzzy match for the model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OVERLAY</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: 20. If the upper limit is exceeded, the error code InvalidParameter.maxResults is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The authorization action dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INFERENCE</b>: model inference authorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INFERENCE</para>
        /// </summary>
        [NameInMap("modelAction")]
        [Validation(Required=false)]
        public string ModelAction { get; set; }

        /// <summary>
        /// <para>The pagination token (offset) for the next page. Do not pass this parameter for the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The workspace ID. This parameter is required and cannot be empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-32klhjk2312334jkh</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
