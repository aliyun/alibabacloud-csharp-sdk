// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIspTypesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The type of the Global Accelerator (GA) instance to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basic</b>: basic GA instance</description></item>
        /// <item><description><b>standard</b>: standard GA instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The ID of the acceleration region to be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BusinessRegionId")]
        [Validation(Required=false)]
        public string BusinessRegionId { get; set; }

    }

}
