// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateChainRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-serialized entity object that describes the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chainconfig</para>
        /// </summary>
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public string ChainConfig { get; set; }

        /// <summary>
        /// <para>The description of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-4cdrlqmhn4gm****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the delivery chain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The collection of repositories excluded from the delivery chain execution.</para>
        /// </summary>
        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

    }

}
