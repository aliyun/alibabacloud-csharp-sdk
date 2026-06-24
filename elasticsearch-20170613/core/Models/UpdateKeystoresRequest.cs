// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKeystoresRequest : TeaModel {
        /// <summary>
        /// <para>Delete keystore configuration</para>
        /// </summary>
        [NameInMap("remove")]
        [Validation(Required=false)]
        public List<string> Remove { get; set; }

        /// <summary>
        /// <para>Add or update keystore</para>
        /// </summary>
        [NameInMap("update")]
        [Validation(Required=false)]
        public Dictionary<string, string> Update { get; set; }

        /// <summary>
        /// <para>Whether to force the change. false: non-forced, true: forced</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

    }

}
