// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskInfoHistoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("BeginCreateTime")]
        [Validation(Required=false)]
        public long? BeginCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("CreateTimeCursor")]
        [Validation(Required=false)]
        public long? CreateTimeCursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aa634d3f-927e-4d17-9d2c-test</para>
        /// </summary>
        [NameInMap("TaskNoCursor")]
        [Validation(Required=false)]
        public string TaskNoCursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
