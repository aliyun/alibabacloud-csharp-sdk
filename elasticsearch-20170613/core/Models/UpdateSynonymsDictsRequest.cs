// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSynonymsDictsRequest : TeaModel {
        /// <summary>
        /// <para>The file name, source, and OSS file information of the synonym dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;SYSTEM_STOPWORD.txt&quot;,&quot;sourceType&quot;:&quot;ORIGIN&quot;,&quot;type&quot;:&quot;SYNONYMS&quot;}]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique across different requests. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
