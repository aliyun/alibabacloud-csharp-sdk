// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateQualityCheckSchemeRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The request parameters in JSON format. For more information, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
