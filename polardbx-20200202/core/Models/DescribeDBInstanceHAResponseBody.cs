// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceHAResponseBody : TeaModel {
        /// <summary>
        /// <para>The high availability deployment information of the instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAResponseBodyData Data { get; set; }
        public class DescribeDBInstanceHAResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The zone ID of the primary node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-d</para>
            /// </summary>
            [NameInMap("PrimaryAzoneId")]
            [Validation(Required=false)]
            public string PrimaryAzoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the primary node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrimaryRegionId")]
            [Validation(Required=false)]
            public string PrimaryRegionId { get; set; }

            /// <summary>
            /// <para>The zone ID of the secondary node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("SecondaryAzoneId")]
            [Validation(Required=false)]
            public string SecondaryAzoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the secondary node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SecondaryRegionId")]
            [Validation(Required=false)]
            public string SecondaryRegionId { get; set; }

            /// <summary>
            /// <para>The high availability topology type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3azones</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successs</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D328C-84B8-40DC-BF49-6C73984D7494</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
