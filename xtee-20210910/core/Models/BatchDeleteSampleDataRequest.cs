// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class BatchDeleteSampleDataRequest : TeaModel {
        /// <summary>
        /// <para>Language of the error message returned by the interface. Values: zh: Chinese; en: English. Default is en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89cd3e44cd2f4a529fb020f3bab3ee1c</para>
        /// </summary>
        [NameInMap("uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
