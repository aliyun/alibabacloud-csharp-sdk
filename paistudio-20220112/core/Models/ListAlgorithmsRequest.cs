// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListAlgorithmsRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>algo-xsldfvu1334</para>
        /// </summary>
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// <para>The algorithm name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The algorithm provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
