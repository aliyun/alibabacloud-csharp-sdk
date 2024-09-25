// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVbrHaResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the VBR was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-08T12:20:55</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the VBR failover group.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the VBR failover group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBRHa</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the other VBR in the VBR failover group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("PeerVbrId")]
        [Validation(Required=false)]
        public string PeerVbrId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the VBR is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the VBR failover group.</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b></description></item>
        /// <item><description><b>Active</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the VBR failover group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbrha-sa1sxheuxtd98****</para>
        /// </summary>
        [NameInMap("VbrHaId")]
        [Validation(Required=false)]
        public string VbrHaId { get; set; }

        /// <summary>
        /// <para>The VBR ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp1jcg5cmxjbl9xgc****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

    }

}
