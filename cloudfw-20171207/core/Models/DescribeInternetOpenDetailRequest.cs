// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-uf6faknmuby7ezht****</para>
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instance_test</para>
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EcsPublicIP</para>
        /// </summary>
        [NameInMap("AssetsType")]
        [Validation(Required=false)]
        public string AssetsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1745251200</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9100</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>203.0.13.XX</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SMB</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SMB</para>
        /// </summary>
        [NameInMap("ServiceNameFuzzy")]
        [Validation(Required=false)]
        public string ServiceNameFuzzy { get; set; }

        [NameInMap("SortList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenDetailRequestSortList> SortList { get; set; }
        public class DescribeInternetOpenDetailRequestSortList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ServiceName</para>
            /// </summary>
            [NameInMap("SortKey")]
            [Validation(Required=false)]
            public string SortKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>222.212.86.7XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SuggestLevel")]
        [Validation(Required=false)]
        public string SuggestLevel { get; set; }

    }

}
