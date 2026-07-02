// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlLastPayloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The destination port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DstPortList")]
        [Validation(Required=false)]
        public string DstPortList { get; set; }

        /// <summary>
        /// <para>The attack payload of the intrusion prevention event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>302902010004067075626c6963a01c0204036a5f43020100020100300e300c06082b060102010101000500</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>The protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ProtoList")]
        [Validation(Required=false)]
        public string ProtoList { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586</para>
        /// </summary>
        [NameInMap("SrcPortList")]
        [Validation(Required=false)]
        public string SrcPortList { get; set; }

    }

}
