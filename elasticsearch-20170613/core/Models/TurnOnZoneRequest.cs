// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class TurnOnZoneRequest : TeaModel {
        [NameInMap("hpAlbZoneDrained")]
        [Validation(Required=false)]
        public bool? HpAlbZoneDrained { get; set; }

        /// <summary>
        /// <para>The zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
