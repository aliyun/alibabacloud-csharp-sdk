// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateSubCNInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the specified region, including the instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzravgpt8q****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically configure compute resource parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>:</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsAutoCreate")]
        [Validation(Required=false)]
        public bool? IsAutoCreate { get; set; }

        /// <summary>
        /// <para>The read/write type. Valid values: ReadWrite (row store read/write) and ColumnarRead (column store read-only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("ReadType")]
        [Validation(Required=false)]
        public string ReadType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
