// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1eo4f57z1kbbcmn****</para>
        /// </summary>
        [NameInMap("BandwidthPackage")]
        [Validation(Required=false)]
        public string BandwidthPackage { get; set; }

        /// <summary>
        /// <para>The description of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DF3A3CB-B621-44F8-9870-C20D034D7AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
