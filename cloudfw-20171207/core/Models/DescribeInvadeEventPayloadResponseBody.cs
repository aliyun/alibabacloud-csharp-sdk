// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventPayloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID of the asset to which the event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6faknmuby7ezht****</para>
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// <para>The unique ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fadd-dfdd-****</para>
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// <para>The end position (character index) of the matched content in the payload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HighlightEnd")]
        [Validation(Required=false)]
        public int? HighlightEnd { get; set; }

        /// <summary>
        /// <para>The start position (character index) of the matched content in the payload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HighlightStart")]
        [Validation(Required=false)]
        public int? HighlightStart { get; set; }

        /// <summary>
        /// <para>The raw packet payload content of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>302902010004067075626c6963a01c0204036a5f43020100020100300e300c06082b060102010101000500</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>The length of the payload in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>457</para>
        /// </summary>
        [NameInMap("PayloadLen")]
        [Validation(Required=false)]
        public int? PayloadLen { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B14757D0-4640-4B44-AC67-7F558FE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
