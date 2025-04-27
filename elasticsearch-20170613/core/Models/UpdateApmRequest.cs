// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateApmRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APMtest</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-i7m2fsfhc001x****</para>
        /// </summary>
        [NameInMap("outputES")]
        [Validation(Required=false)]
        public string OutputES { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ESPassword****</para>
        /// </summary>
        [NameInMap("outputESPassword")]
        [Validation(Required=false)]
        public string OutputESPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>elastic</para>
        /// </summary>
        [NameInMap("outputESUserName")]
        [Validation(Required=false)]
        public string OutputESUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AMPPassword****</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
