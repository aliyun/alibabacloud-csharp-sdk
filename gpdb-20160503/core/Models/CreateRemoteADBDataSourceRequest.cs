// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateRemoteADBDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>Customer-specified DataSourceName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>Instance ID of the data being used (required).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-test1</para>
        /// </summary>
        [NameInMap("LocalDBInstanceId")]
        [Validation(Required=false)]
        public string LocalDBInstanceId { get; set; }

        /// <summary>
        /// <para>Database name of the data being used (required)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1</para>
        /// </summary>
        [NameInMap("LocalDatabase")]
        [Validation(Required=false)]
        public string LocalDatabase { get; set; }

        /// <summary>
        /// <para>Management account of the data-using instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>managerAccount</para>
        /// </summary>
        [NameInMap("ManagerUserName")]
        [Validation(Required=false)]
        public string ManagerUserName { get; set; }

        /// <summary>
        /// <para>Password of the management account of the data-using instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password2</para>
        /// </summary>
        [NameInMap("ManagerUserPassword")]
        [Validation(Required=false)]
        public string ManagerUserPassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Instance ID providing the data (required).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-test2</para>
        /// </summary>
        [NameInMap("RemoteDBInstanceId")]
        [Validation(Required=false)]
        public string RemoteDBInstanceId { get; set; }

        /// <summary>
        /// <para>Database name providing the data (required).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db2</para>
        /// </summary>
        [NameInMap("RemoteDatabase")]
        [Validation(Required=false)]
        public string RemoteDatabase { get; set; }

        /// <summary>
        /// <para>Account name of the data-providing instance used for user mapping (required).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account1</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>Password of the data-providing instance account used for user mapping.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password1</para>
        /// </summary>
        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

    }

}
