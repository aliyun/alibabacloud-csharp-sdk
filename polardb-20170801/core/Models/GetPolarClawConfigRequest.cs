// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetPolarClawConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Usage note: In the Prerequisites section, specify that the ApplicationId can be obtained by calling DescribeApplications (filtered by ApplicationType=polardb_polarclaw), and indicate the retrieval path in the description of the ApplicationId parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Filters configuration sections by a JSONPath dot-notation path. If this parameter is left empty, all configurations are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>models</para>
        /// </summary>
        [NameInMap("ConfigPath")]
        [Validation(Required=false)]
        public string ConfigPath { get; set; }

    }

}
