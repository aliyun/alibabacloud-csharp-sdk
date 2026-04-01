// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKeystoresRequest : TeaModel {
        [NameInMap("remove")]
        [Validation(Required=false)]
        public List<string> Remove { get; set; }

        [NameInMap("update")]
        [Validation(Required=false)]
        public Dictionary<string, string> Update { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

    }

}
