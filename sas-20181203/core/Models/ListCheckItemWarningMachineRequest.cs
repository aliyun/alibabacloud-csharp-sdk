// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningMachineRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The name of the field that is used to query containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the field that is used to query containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce89cdd0ea732472a8703821b19e****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/130972.html">DescribeAllGroups</a> operation to query the ID of the asset group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1161****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword that is used to query servers in fuzzy match mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>225</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The type of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cis</para>
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

        /// <summary>
        /// <para>The data source. Default value: default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: The check items of baselines for hosts.</description></item>
        /// <item><description><b>agentless</b>: The check items of baselines for agentless detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The status of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed</description></item>
        /// <item><description><b>2</b>: verifying</description></item>
        /// <item><description><b>3</b>: passed</description></item>
        /// <item><description><b>6</b>: ignored</description></item>
        /// <item><description><b>7</b>: fixing</description></item>
        /// <item><description><b>8</b>: fixed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUID array of the servers.</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
