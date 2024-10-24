// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class AttachEaisEiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp14ws9hbt1oe0u9****</para>
        /// </summary>
        [NameInMap("ClientInstanceId")]
        [Validation(Required=false)]
        public string ClientInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-hzu00xufs1c8j5nn****</para>
        /// </summary>
        [NameInMap("EiInstanceId")]
        [Validation(Required=false)]
        public string EiInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eais.ei-a6.2xlarge</para>
        /// </summary>
        [NameInMap("EiInstanceType")]
        [Validation(Required=false)]
        public string EiInstanceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
