// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp when the diagnostic report was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("diagnoseItems")]
        [Validation(Required=false)]
        public List<string> DiagnoseItems { get; set; }

        [NameInMap("indices")]
        [Validation(Required=false)]
        public List<string> Indices { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
