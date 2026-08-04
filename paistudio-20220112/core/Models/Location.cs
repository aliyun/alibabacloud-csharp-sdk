// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Location : TeaModel {
        /// <summary>
        /// <para>The code location type. Valid values: OSS and NAS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("LocationType")]
        [Validation(Required=false)]
        public string LocationType { get; set; }

        /// <summary>
        /// <para>The code path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://${bucket_name}.oss-${region}.aliyuncs.com/oss/location/path/</para>
        /// </summary>
        [NameInMap("LocationValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> LocationValue { get; set; }

    }

}
