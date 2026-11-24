// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of cloud desktop information.</para>
        /// </summary>
        [NameInMap("DesktopItems")]
        [Validation(Required=false)]
        public List<DescribeDesktopIdsByVulNamesResponseBodyDesktopItems> DesktopItems { get; set; }
        public class DescribeDesktopIdsByVulNamesResponseBodyDesktopItems : TeaModel {
            /// <summary>
            /// <para>The cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-138dsptkrt00u****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Graphics-21</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
