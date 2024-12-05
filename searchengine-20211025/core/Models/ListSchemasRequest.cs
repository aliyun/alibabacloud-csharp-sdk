// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListSchemasRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the MaxCompute data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ak</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The AccessKey secret of the MaxCompute data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>as</para>
        /// </summary>
        [NameInMap("accessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        /// <summary>
        /// <para>The endpoint of the MaxCompute data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The namespace of the SARO data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>igraph-cn-tl32wnrhi04</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The shard name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=20230520</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project that is used as the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start-flask-v3-obcc</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table that is used as the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.</para>
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
