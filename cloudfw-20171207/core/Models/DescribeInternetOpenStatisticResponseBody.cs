// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("InternetIpNum")]
        [Validation(Required=false)]
        public int? InternetIpNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("InternetPortNum")]
        [Validation(Required=false)]
        public int? InternetPortNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("InternetRiskIpNum")]
        [Validation(Required=false)]
        public int? InternetRiskIpNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InternetRiskPortNum")]
        [Validation(Required=false)]
        public int? InternetRiskPortNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InternetRiskServiceNum")]
        [Validation(Required=false)]
        public int? InternetRiskServiceNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("InternetServiceNum")]
        [Validation(Required=false)]
        public int? InternetServiceNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetSlbIpNum")]
        [Validation(Required=false)]
        public int? InternetSlbIpNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("InternetSlbIpPortNum")]
        [Validation(Required=false)]
        public int? InternetSlbIpPortNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("InternetUnprotectedPortNum")]
        [Validation(Required=false)]
        public int? InternetUnprotectedPortNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6AB7822C-0D73-5D1D-81FD-45D4FB7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
