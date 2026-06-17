// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetPolarClawConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The path to the configuration section to retrieve, specified in JSONPath dot notation. If this parameter is empty, the entire configuration is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>models</para>
        /// </summary>
        [NameInMap("ConfigPath")]
        [Validation(Required=false)]
        public string ConfigPath { get; set; }

    }

}
