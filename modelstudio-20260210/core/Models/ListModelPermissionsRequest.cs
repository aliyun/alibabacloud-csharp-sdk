// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The query dimension for the authorization scope.</para>
        /// <list type="bullet">
        /// <item><description><b>AUTHORIZED</b>: models that are authorized for the specified modelAction. This value must be used together with modelAction.</description></item>
        /// <item><description><b>AUTHORIZABLE</b>: all authorizable directories.</description></item>
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
        /// <para>The maximum number of entries to return on each page. Default value: 20. If the value exceeds the upper limit, the <c>InvalidParameter.maxResults</c> error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The authorization action dimension.</para>
        /// <list type="bullet">
        /// <item><description><b>INFERENCE</b>: model invocation authorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INFERENCE</para>
        /// </summary>
        [NameInMap("modelAction")]
        [Validation(Required=false)]
        public string ModelAction { get; set; }

        /// <summary>
        /// <para>The pagination token that is used to retrieve the next page. This parameter is not required for the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. This parameter is required.</para>
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
