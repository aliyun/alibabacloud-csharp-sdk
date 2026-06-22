// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2546</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The type of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hc.check.type.identity_auth</b>: identity authentication</description></item>
        /// <item><description><b>hc.check.type.access_control</b>: access control</description></item>
        /// <item><description><b>hc.check.type.network_service</b>: network and service</description></item>
        /// <item><description><b>hc.check.type.service_conf</b>: service configuration</description></item>
        /// <item><description><b>hc.check.type.file_rights</b>: file permission</description></item>
        /// <item><description><b>hc.check.type.security_audit</b>: security audit</description></item>
        /// <item><description><b>hc.check.type.attack_defense</b>: intrusion prevention</description></item>
        /// <item><description><b>hc.check.type.others</b>: others.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hc.check.type.attack_defense</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/redis</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of check items to display on each page in a paged query. Default value: <b>20</b>, which indicates that 20 check items are displayed on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The risk item ID. This parameter is required.</para>
        /// <remarks>
        /// <para>To query check item information for a specified risk item and a specified server, you must provide the risk item ID. You can call the <a href="~~DescribeCheckWarningSummary~~">DescribeCheckWarningSummary</a> operation to obtain this ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10354</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// <para>The risk detection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed</description></item>
        /// <item><description><b>2</b>: verifying</description></item>
        /// <item><description><b>3</b>: passed</description></item>
        /// <item><description><b>5</b>: expired</description></item>
        /// <item><description><b>6</b>: ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public int? RiskStatus { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the server on which the baseline check is performed.</para>
        /// <remarks>
        /// <para>To query check item information for a specified risk item and a specified server, you must provide the ID of the server on which the baseline check is performed. You can call the <a href="~~DescribeWarningMachines~~">DescribeWarningMachines</a> operation to obtain this ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d42f938c-d962-48a0-90f9-05****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
