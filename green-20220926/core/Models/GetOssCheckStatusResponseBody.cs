// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Bid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>Whether a product has been activated on Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Buy")]
        [Validation(Required=false)]
        public bool? Buy { get; set; }

        /// <summary>
        /// <para>Commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>Whether there is an outstanding payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Indebt")]
        [Validation(Required=false)]
        public bool? Indebt { get; set; }

        /// <summary>
        /// <para>Whether internal security is authorized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RamStatus")]
        [Validation(Required=false)]
        public string RamStatus { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether log analysis function is authorized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SlsStatus")]
        [Validation(Required=false)]
        public string SlsStatus { get; set; }

    }

}
