// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateChainRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the delivery chain in the JSON format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chainconfig</para>
        /// </summary>
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public string ChainConfig { get; set; }

        /// <summary>
        /// <para>The ID of the delivery chain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chi-02ymhtwl3cq8****</para>
        /// </summary>
        [NameInMap("ChainId")]
        [Validation(Required=false)]
        public string ChainId { get; set; }

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
        /// <para>The ID of the instance.</para>
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
        /// <para>Repositories in which the delivery chain does not take effect.</para>
        /// </summary>
        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

    }

}
