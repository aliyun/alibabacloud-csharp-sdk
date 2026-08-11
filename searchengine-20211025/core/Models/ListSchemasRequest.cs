// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListSchemasRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the ODPS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L***p</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The alias of an ODPS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5**9a6</para>
        /// </summary>
        [NameInMap("accessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        /// <summary>
        /// <para>The endpoint of the ODPS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The namespace of the Saro data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imm</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The data partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=20230520</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The name of the ODPS data source project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sec_odps</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The name of the table in the Saro or ODPS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>odps, swift, saro, oss, unknown</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
