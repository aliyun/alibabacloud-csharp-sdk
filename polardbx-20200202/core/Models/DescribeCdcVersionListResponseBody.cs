// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCdcVersionListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCdcVersionListResponseBodyData Data { get; set; }
        public class DescribeCdcVersionListResponseBodyData : TeaModel {
            [NameInMap("VersionList")]
            [Validation(Required=false)]
            public List<string> VersionList { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>97632117-E477-5FE8-B424-F059CBBDD919</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
