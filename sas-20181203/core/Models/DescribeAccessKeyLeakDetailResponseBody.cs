// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccessKeyLeakDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AccessKey pair that is leaked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI4G4VjkC9wenfEvgX****</para>
        /// </summary>
        [NameInMap("AccesskeyId")]
        [Validation(Required=false)]
        public string AccesskeyId { get; set; }

        /// <summary>
        /// <para>The platform to which the asset belongs. The value is fixed as <b>Cloud platform</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud platform</para>
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public string Asset { get; set; }

        /// <summary>
        /// <para>The code snippet that is leaked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\n1231 \nak=LTAI4G4VjkC9wenfEvgX**** \n12311123 \nsk1999 \nsk1999sk1999 \nsk1999sk1999 \n\n\ntest001 ak hht \nak=LTAI4G4VjkC9wenfEvgX**** \nsk=AjEhS9XmnIzllpAx2LxMTMdrTG****</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the AccessKey pair leak was handled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-17 15:47:08</para>
        /// </summary>
        [NameInMap("DealTime")]
        [Validation(Required=false)]
        public string DealTime { get; set; }

        /// <summary>
        /// <para>The solution to the AccessKey pair leak. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual</b>: manually deleted</description></item>
        /// <item><description><b>disable</b>: manually disabled</description></item>
        /// <item><description><b>add-whitelist</b>: added to the whitelist</description></item>
        /// <item><description><b>pending</b>: unhandled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add-whitelist</para>
        /// </summary>
        [NameInMap("DealType")]
        [Validation(Required=false)]
        public string DealType { get; set; }

        /// <summary>
        /// <para>The name of the GitHub file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testAkLeak</para>
        /// </summary>
        [NameInMap("GithubFileName")]
        [Validation(Required=false)]
        public string GithubFileName { get; set; }

        /// <summary>
        /// <para>The type of the GitHub file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Python</description></item>
        /// <item><description>XML</description></item>
        /// <item><description>GO</description></item>
        /// <item><description>Javascript</description></item>
        /// <item><description>INI</description></item>
        /// <item><description>JSON</description></item>
        /// <item><description>C++</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Python</para>
        /// </summary>
        [NameInMap("GithubFileType")]
        [Validation(Required=false)]
        public string GithubFileType { get; set; }

        /// <summary>
        /// <para>The time when the GitHub file was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T09:49:33</para>
        /// </summary>
        [NameInMap("GithubFileUpdateTime")]
        [Validation(Required=false)]
        public string GithubFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The URL of the GitHub file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com/Blue00Blue/ExamOnline/blob/6c932c10fc3f217783f3937e2b230f79656c18a7/testAk">https://github.com/Blue00Blue/ExamOnline/blob/6c932c10fc3f217783f3937e2b230f79656c18a7/testAk</a>****</para>
        /// </summary>
        [NameInMap("GithubFileUrl")]
        [Validation(Required=false)]
        public string GithubFileUrl { get; set; }

        /// <summary>
        /// <para>The name of the GitHub repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExamOnline</para>
        /// </summary>
        [NameInMap("GithubRepoName")]
        [Validation(Required=false)]
        public string GithubRepoName { get; set; }

        /// <summary>
        /// <para>The URL of the GitHub repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com/Blue00Blue/ExamOn">https://github.com/Blue00Blue/ExamOn</a>****</para>
        /// </summary>
        [NameInMap("GithubRepoUrl")]
        [Validation(Required=false)]
        public string GithubRepoUrl { get; set; }

        /// <summary>
        /// <para>The username of the GitHub user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blue00Blue</para>
        /// </summary>
        [NameInMap("GithubUser")]
        [Validation(Required=false)]
        public string GithubUser { get; set; }

        /// <summary>
        /// <para>The URL of the profile picture for the GitHub user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://avatars.githubusercontent.com/u/26296896?s=48&v=">https://avatars.githubusercontent.com/u/26296896?s=48&amp;v=</a>****</para>
        /// </summary>
        [NameInMap("GithubUserPicUrl")]
        [Validation(Required=false)]
        public string GithubUserPicUrl { get; set; }

        /// <summary>
        /// <para>The first time when the AccessKey pair leak was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06 17:49:41</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last time when the AccessKey pair leak was detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06 17:49:39</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The remarks of the AccessKey pair leak.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The platform on which the AccessKey pair leak is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GitHub</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The validity of the key that is associated with the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: to be confirmed.</description></item>
        /// <item><description><b>1</b>: valid.</description></item>
        /// <item><description><b>2</b>: invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TokenValid")]
        [Validation(Required=false)]
        public int? TokenValid { get; set; }

        /// <summary>
        /// <para>The type of the leak. The value is fixed as <b>AccessKey</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessKey</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Indicates whether the AccessKey pair leak is added to the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>: no</description></item>
        /// <item><description><b>yes</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("WhitelistStatus")]
        [Validation(Required=false)]
        public string WhitelistStatus { get; set; }

        /// <summary>
        /// <para>The time when the AccessKey pair was added to the whitelist. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689172004478</para>
        /// </summary>
        [NameInMap("WhitelistTime")]
        [Validation(Required=false)]
        public long? WhitelistTime { get; set; }

    }

}
