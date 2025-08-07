// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetErrorRequest : TeaModel {
        /// <summary>
        /// <para>appKey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233588686</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>h5Resource</para>
        /// </summary>
        [NameInMap("BizModule")]
        [Validation(Required=false)]
        public string BizModule { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739808000000</para>
        /// </summary>
        [NameInMap("ClientTime")]
        [Validation(Required=false)]
        public long? ClientTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>233588686</para>
        /// </summary>
        [NameInMap("Did")]
        [Validation(Required=false)]
        public string Did { get; set; }

        [NameInMap("DigestHash")]
        [Validation(Required=false)]
        public string DigestHash { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcf4a4b-158c-4a0b-b81c-262785d84c4f</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
