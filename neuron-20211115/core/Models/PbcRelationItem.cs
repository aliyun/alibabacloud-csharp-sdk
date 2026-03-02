// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcRelationItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>企业服务</para>
        /// </summary>
        [NameInMap("company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中驿</para>
        /// </summary>
        [NameInMap("developer")]
        [Validation(Required=false)]
        public string Developer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>category</para>
        /// </summary>
        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("pbcVersion")]
        [Validation(Required=false)]
        public string PbcVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>资产市场</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
