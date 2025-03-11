// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the instance version.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceVersionResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.3.12-15682777</para>
            /// </summary>
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }

            /// <summary>
            /// <para>The latest version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.4.12-16315258</para>
            /// </summary>
            [NameInMap("NewestVersion")]
            [Validation(Required=false)]
            public string NewestVersion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F7F8080-9132-4279-85D0-B7E5C4305162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
