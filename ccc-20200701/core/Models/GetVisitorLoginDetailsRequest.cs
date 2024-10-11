// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetVisitorLoginDetailsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c51c9116c36537cb850dc1081d745df</para>
        /// </summary>
        [NameInMap("ChatDeviceId")]
        [Validation(Required=false)]
        public string ChatDeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9XYGTGWtq2wFi_Bpg7aUnIoYi_vG_rO3b<em><b>YtsxbHRHrYHlz1LDBLJAyZcLxieRQR4h_6AnWvTjJeNU5jgxzO</b></em>**bHwej7WgWrmA</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcd020fe-d8e4-40e5-8c77-1a272a174a7d</para>
        /// </summary>
        [NameInMap("VisitorId")]
        [Validation(Required=false)]
        public string VisitorId { get; set; }

    }

}
