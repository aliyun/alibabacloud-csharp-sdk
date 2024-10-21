// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class GetQualificationUploadPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hObpgEXoca42****</para>
        /// </summary>
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20211220/131953297274****_4de3db85-4f98-488d-845b-d75bf035b13d</para>
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1593688811881</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https://<b><b><b><b>-review.oss-cn-</b></b></b></b>.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAaMC0wNy0wMlQxKToyMDoxMS44ODRaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNTI0Mjg4MDBdLFsic3RhcnRzLXdpdGgiLCIka2V5IiwiMTIxOTU0MTE2MTIxMzA1Ny9PRkZMSU5FX1RSQU5TRkVSLzE1OTM2ODg1MTE4ODMi****</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20211220/131953297274****<em>4de3db85-4f98-488d-845b-d75bf035b13d</em>${filename}</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pNVECGkyL0tl4bKXekV5ErZ****</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
