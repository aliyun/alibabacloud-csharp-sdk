// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Location : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("LocationType")]
        [Validation(Required=false)]
        public string LocationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://${bucket_name}.oss-${region}.aliyuncs.com/oss/location/path/</para>
        /// </summary>
        [NameInMap("LocationValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> LocationValue { get; set; }

    }

}
