// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried source IP addresses.</para>
        /// </summary>
        [NameInMap("ClientIps")]
        [Validation(Required=false)]
        public List<string> ClientIps { get; set; }

        /// <summary>
        /// <para>The queried database names.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEA97C6B-D7A4-5E69-9EFC-D7F88737CED5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried resource group names.</para>
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<string> ResourceGroups { get; set; }

        /// <summary>
        /// <para>The queried usernames.</para>
        /// </summary>
        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
