// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateAliwsDictRequest : TeaModel {
        /// <summary>
        /// <para>The file name, source, and OSS file information of the AliNLP word segmentation dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;deploy_0.txt&quot;,&quot;ossObject&quot;:{&quot;bucketName&quot;:&quot;search-cloud-test-cn-****&quot;,&quot;key&quot;:&quot;user_dict/dict_0.txt&quot;},&quot;sourceType&quot;:&quot;OSS&quot;,&quot;type&quot;:&quot;ALI_WS&quot;},{&quot;name&quot;:&quot;aliws_ext_dict.txt&quot;,&quot;sourceType&quot;:&quot;ORIGIN&quot;,&quot;type&quot;:&quot;ALI_WS&quot;}]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
