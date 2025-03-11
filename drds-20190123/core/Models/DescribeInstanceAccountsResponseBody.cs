// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the information about the instance accounts.</para>
        /// </summary>
        [NameInMap("InstanceAccounts")]
        [Validation(Required=false)]
        public DescribeInstanceAccountsResponseBodyInstanceAccounts InstanceAccounts { get; set; }
        public class DescribeInstanceAccountsResponseBodyInstanceAccounts : TeaModel {
            [NameInMap("InstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount> InstanceAccount { get; set; }
            public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount : TeaModel {
                /// <summary>
                /// <para>Indicates the username of an instance account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_rds3</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Indicates the type of an instance account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The instance account is a privileged account.</description></item>
                /// <item><description><b>1</b>: The instance account is a standard account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public int? AccountType { get; set; }

                /// <summary>
                /// <para>Indicates the information about the permissions of an account on a database.</para>
                /// </summary>
                [NameInMap("DbPrivileges")]
                [Validation(Required=false)]
                public DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges DbPrivileges { get; set; }
                public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges : TeaModel {
                    [NameInMap("DbPrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege> DbPrivilege { get; set; }
                    public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege : TeaModel {
                        /// <summary>
                        /// <para>Indicates the name of a database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test_rds3</para>
                        /// </summary>
                        [NameInMap("DbName")]
                        [Validation(Required=false)]
                        public string DbName { get; set; }

                        /// <summary>
                        /// <para>Indicates the permissions that an account is granted on the database. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>R</b>: The account is granted the permissions that are required to read the data of the database.</description></item>
                        /// <item><description><b>W</b>: The account is granted the permissions that are required to write data to the database.</description></item>
                        /// <item><description><b>DDL</b>: The account is granted the permissions that are required to perform DDL operations on the database.</description></item>
                        /// <item><description><b>DML</b>: The account is granted the permissions that are required to perform DML operations on the database.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>R</para>
                        /// </summary>
                        [NameInMap("Privilege")]
                        [Validation(Required=false)]
                        public string Privilege { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates the description of an account. By default, if 0 is the value of the AccountType parameter, <b>Created by DRDS</b> is returned as the value of the Description parameter. If 1 is the value of the AccountType parameter, an empty string is returned as the value of the Description parameter. You can modify the description of an account on the Accounts page in the PolarDB-X console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created by DRDS</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates an IP address that is allowed to access the database. The value <b>%</b> indicates that each IP address is allowed to access the database. \</note></para>
                /// 
                /// <b>Example:</b>
                /// <para>%</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2E4056D-57EB-4353-8355-2E6284******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
