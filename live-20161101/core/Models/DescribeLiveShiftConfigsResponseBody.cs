// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveShiftConfigsResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeLiveShiftConfigsResponseBodyContent Content { get; set; }
        public class DescribeLiveShiftConfigsResponseBodyContent : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<DescribeLiveShiftConfigsResponseBodyContentConfig> Config { get; set; }
            public class DescribeLiveShiftConfigsResponseBodyContentConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("IgnoreTranscode")]
                [Validation(Required=false)]
                public bool? IgnoreTranscode { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("Vision")]
                [Validation(Required=false)]
                public int? Vision { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B49E6DDA-F413-422B-B58E-2FA23F286726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
