// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveShiftConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The time shifting configurations.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeLiveShiftConfigsResponseBodyContent Content { get; set; }
        public class DescribeLiveShiftConfigsResponseBodyContent : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<DescribeLiveShiftConfigsResponseBodyContentConfig> Config { get; set; }
            public class DescribeLiveShiftConfigsResponseBodyContentConfig : TeaModel {
                /// <summary>
                /// <para>The application for which you configure time shifting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The domain name for which you configure time shifting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Whether to ignore time shift generation for the transcode stream.</para>
                /// <list type="bullet">
                /// <item><description>true: Ignore time shifting generation.</description></item>
                /// <item><description>false: Generate time shifting.</description></item>
                /// </list>
                /// <para>The default value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreTranscode")]
                [Validation(Required=false)]
                public bool? IgnoreTranscode { get; set; }

                /// <summary>
                /// <para>The name of the live stream for which you configure time shifting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The number of days for which the time shifting configurations are retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
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
