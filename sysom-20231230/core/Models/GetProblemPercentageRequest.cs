// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetProblemPercentageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1808078950770264</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725801327754</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public float? End { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-wz9d00ut2ska3mlyhn6j</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725797727754</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public float? Start { get; set; }

    }

}
