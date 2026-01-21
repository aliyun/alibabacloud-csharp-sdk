// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifySlsDispatchStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>internet_log</para>
        /// </summary>
        [NameInMap("DispatchValue")]
        [Validation(Required=false)]
        public string DispatchValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>attack,acl</para>
        /// </summary>
        [NameInMap("FilterKeys")]
        [Validation(Required=false)]
        public string FilterKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("NewRegionId")]
        [Validation(Required=false)]
        public string NewRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
