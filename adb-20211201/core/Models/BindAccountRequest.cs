// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class BindAccountRequest : TeaModel {
        /// <summary>
        /// <para>The standard account of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_accout</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz99d9nh532****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1444832459****</para>
        /// </summary>
        [NameInMap("RamUser")]
        [Validation(Required=false)]
        public string RamUser { get; set; }

    }

}
