// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventPayloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The destination IP address of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.1</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The destination port of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        /// <summary>
        /// <para>The destination VPC ID of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp10w5nb30r4jzfyc****</para>
        /// </summary>
        [NameInMap("DstVpcId")]
        [Validation(Required=false)]
        public string DstVpcId { get; set; }

        /// <summary>
        /// <para>Type of the hit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HitContentType")]
        [Validation(Required=false)]
        public int? HitContentType { get; set; }

        /// <summary>
        /// <para>The position where the hit ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67</para>
        /// </summary>
        [NameInMap("HitTo")]
        [Validation(Required=false)]
        public int? HitTo { get; set; }

        /// <summary>
        /// <para>Hit payload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f636f6d706f7365722f73656e645f656d61696c3f746f3d6d61667740776f66736f7961792675726c3d687474703a2f2f302e302e302e303a31323334352f692f6431366530312f313664622f673670772f</para>
        /// </summary>
        [NameInMap("ParsedContent")]
        [Validation(Required=false)]
        public string ParsedContent { get; set; }

        /// <summary>
        /// <para>The attack payload of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>302902010004067075626c6963a01c0204036a5f43020100020100300e300c06082b060102010101000500</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>The length of the attack payload of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>457</para>
        /// </summary>
        [NameInMap("PayloadLen")]
        [Validation(Required=false)]
        public int? PayloadLen { get; set; }

        /// <summary>
        /// <para>The protocol type of intrusion event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The HTTP X-Real-IP field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.3</para>
        /// </summary>
        [NameInMap("RealIp")]
        [Validation(Required=false)]
        public string RealIp { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68055BA4-D8BD-5611-AC49-C651E619A12E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source IP address of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.2</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <para>The source port of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54360</para>
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// <para>The source VPC ID of the intrusion event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4nlt09olhpazpoeg****</para>
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// <para>The HTTP X-Forwarded-For field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.4</para>
        /// </summary>
        [NameInMap("XForwardFor")]
        [Validation(Required=false)]
        public string XForwardFor { get; set; }

    }

}
