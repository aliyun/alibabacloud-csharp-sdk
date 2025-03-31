// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of delivery chains.</para>
        /// </summary>
        [NameInMap("Chains")]
        [Validation(Required=false)]
        public List<ListChainResponseBodyChains> Chains { get; set; }
        public class ListChainResponseBodyChains : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chi-0ops0gsmw5x2****</para>
            /// </summary>
            [NameInMap("ChainId")]
            [Validation(Required=false)]
            public string ChainId { get; set; }

            /// <summary>
            /// <para>The time when the delivery chain was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638255427000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>cri-4cdrlqmhn4gm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the delivery chain was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638259914000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the delivery chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Repositories to which the delivery chain does not apply.</para>
            /// </summary>
            [NameInMap("ScopeExclude")]
            [Validation(Required=false)]
            public List<string> ScopeExclude { get; set; }

            /// <summary>
            /// <para>The ID of the delivery chain scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-nyrh2oko32xb****</para>
            /// </summary>
            [NameInMap("ScopeId")]
            [Validation(Required=false)]
            public string ScopeId { get; set; }

            /// <summary>
            /// <para>The type of the delivery chain scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REPOSITORY</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85A99B10-3926-5201-958E-C06FA47F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of delivery chains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
