// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6faknmuby7ezht****</para>
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the asset. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_test</para>
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// <para>The type of the asset for an exact match. If you leave this parameter empty, all asset types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EcsPublicIP</para>
        /// </summary>
        [NameInMap("AssetsType")]
        [Validation(Required=false)]
        public string AssetsType { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1745251200</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The port for an exact match. The value must be an integer from 1 to 65535. If you leave this parameter empty, all ports are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9100</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The public IP address for an exact match. If you leave this parameter empty, all public IP addresses are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.13.XX</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The risk level. If you leave this parameter empty, all risk levels are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The name of the application for an exact match. If you leave this parameter empty, all applications are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMB</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The name of the application for a fuzzy match. If you leave this parameter empty, all applications are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMB</para>
        /// </summary>
        [NameInMap("ServiceNameFuzzy")]
        [Validation(Required=false)]
        public string ServiceNameFuzzy { get; set; }

        /// <summary>
        /// <para>The sorting conditions.</para>
        /// </summary>
        [NameInMap("SortList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenDetailRequestSortList> SortList { get; set; }
        public class DescribeInternetOpenDetailRequestSortList : TeaModel {
            /// <summary>
            /// <para>The sort order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The sorting key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceName</para>
            /// </summary>
            [NameInMap("SortKey")]
            [Validation(Required=false)]
            public string SortKey { get; set; }

        }

        /// <summary>
        /// <para>The source IP address of the access request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222.212.86.7XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The recommended policy level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SuggestLevel")]
        [Validation(Required=false)]
        public string SuggestLevel { get; set; }

    }

}
