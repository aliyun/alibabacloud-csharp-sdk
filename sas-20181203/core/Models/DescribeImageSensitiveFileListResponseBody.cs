// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageSensitiveFileListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageSensitiveFileListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The key of the last data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAGYXFWIAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM1Mzc3Njc4MzA2ODY5NmI2YTY1Nzg2NTcxNjE2NDc4NjE=</para>
            /// </summary>
            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D19A089-E6BC-5244-800C-7E590D50487F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the sensitive files.</para>
        /// </summary>
        [NameInMap("SensitiveFileList")]
        [Validation(Required=false)]
        public List<DescribeImageSensitiveFileListResponseBodySensitiveFileList> SensitiveFileList { get; set; }
        public class DescribeImageSensitiveFileListResponseBodySensitiveFileList : TeaModel {
            /// <summary>
            /// <para>The suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Assess risks based on business conditions, remove risky content.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// <para>The key of the sensitive file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("ClassKey")]
            [Validation(Required=false)]
            public string ClassKey { get; set; }

            /// <summary>
            /// <para>The name of the sensitive file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <para>The number of scans that are performed on the sensitive file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The description of the sensitive file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify the validity of the leaked AK.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the first scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663321552000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663321552000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The type of the alert for the sensitive file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>npm_token</b>: Node Package Manager (NPM) access token.</description></item>
            /// <item><description><b>ftp_cfg</b>: FTP configuration.</description></item>
            /// <item><description><b>google_oauth_key</b>: Google OAuth key.</description></item>
            /// <item><description><b>planetscale_passwd</b>: PlanetScale password.</description></item>
            /// <item><description><b>github_ssh_key</b>: GitHub SSH key.</description></item>
            /// <item><description><b>msbuild_publish_profile</b>: MSBuild publish profile.</description></item>
            /// <item><description><b>fastly_cdn_token</b>: Fastly CDN token.</description></item>
            /// <item><description><b>ssh_private_key</b>: SSH private key.</description></item>
            /// <item><description><b>aws_cli</b>: Amazon Web Services (AWS) CLI credential.</description></item>
            /// <item><description><b>cpanel_proftpd</b>: cPanel ProFTPD credential.</description></item>
            /// <item><description><b>postgresql_passwd</b>: PostgreSQL password file.</description></item>
            /// <item><description><b>discord_client_cred</b>: Discord client credential.</description></item>
            /// <item><description><b>rails_database</b>: Rails database configuration.</description></item>
            /// <item><description><b>aws_access_key</b>: AWS access key.</description></item>
            /// <item><description><b>esmtp_cfg</b>: Extended Simple Mail Transfer Protocol (ESMTP) configuration.</description></item>
            /// <item><description><b>docker_registry_cfg</b>: Docker image repository configuration.</description></item>
            /// <item><description><b>pem</b>: Privacy-Enhanced Mail (PEM).</description></item>
            /// <item><description><b>common_cred</b>: common credential.</description></item>
            /// <item><description><b>sftp_cfg</b>: Secure File Transfer Protocol (SFTP) connection configuration.</description></item>
            /// <item><description><b>grafana_token</b>: Grafana token.</description></item>
            /// <item><description><b>slack_token</b>: Slack token.</description></item>
            /// <item><description><b>ec_private_key</b>: EC private key.</description></item>
            /// <item><description><b>pypi_token</b>: upload token for the Python Package Index (PyPI).</description></item>
            /// <item><description><b>finicity_token</b>: Finicity token.</description></item>
            /// <item><description><b>k8s_client_key</b>: Kubernetes client private key.</description></item>
            /// <item><description><b>git_cfg</b>: Git configuration.</description></item>
            /// <item><description><b>django_key</b>: Django key.</description></item>
            /// <item><description><b>jenkins_ssh</b>: Jenkins SSH configuration file.</description></item>
            /// <item><description><b>openssh_private_key</b>: OpenSSH private key.</description></item>
            /// <item><description><b>square_oauth</b>: OAuth credential for Square.</description></item>
            /// <item><description><b>typeform_token</b>: Typeform token.</description></item>
            /// <item><description><b>common_database_cfg</b>: general database connection configuration.</description></item>
            /// <item><description><b>wordpress_database_cfg</b>: WordPress database configuration.</description></item>
            /// <item><description><b>googlecloud_api_key</b>: API key for Google Cloud.</description></item>
            /// <item><description><b>vscode_sftp</b>: VS Code SFTP configuration.</description></item>
            /// <item><description><b>apache_htpasswd</b>: Apache htpasswd.</description></item>
            /// <item><description><b>planetscale_token</b>: PlanetScale token.</description></item>
            /// <item><description><b>contentful_preview_token</b>: preview token for Contentful.</description></item>
            /// <item><description><b>php_database_cfg</b>: database password for a PHP application.</description></item>
            /// <item><description><b>atom_remote_sync</b>: Atom remote synchronization configuration.</description></item>
            /// <item><description><b>aws_session_token</b>: AWS session token.</description></item>
            /// <item><description><b>atom_sftp_cfg</b>: Atom SFTP configuration.</description></item>
            /// <item><description><b>asana_client_private_key</b>: Asana client key.</description></item>
            /// <item><description><b>tencentcloud_ak</b>: secret ID of a third-party cloud.</description></item>
            /// <item><description><b>rsa_private_key</b>: Rivest-Shamir-Adleman (RSA) private key.</description></item>
            /// <item><description><b>github_personal_token</b>: personal access token for GitHub.</description></item>
            /// <item><description><b>pgp</b>: Pretty Good Privacy (PGP) encrypted file.</description></item>
            /// <item><description><b>stripe_skpk</b>: Stripe secret key.</description></item>
            /// <item><description><b>square_token</b>: Square access token.</description></item>
            /// <item><description><b>rails_carrierwave</b>: file upload credential for Rails Carrierwave.</description></item>
            /// <item><description><b>dbeaver_database_cfg</b>: DBeaver database configuration.</description></item>
            /// <item><description><b>robomongo_cred</b>: Robomongo credential.</description></item>
            /// <item><description><b>github_oauth_token</b>: OAuth access token for GitHub.</description></item>
            /// <item><description><b>pulumi_token</b>: Pulumi token.</description></item>
            /// <item><description><b>ventrilo_voip</b>: Ventrilo VoIP server configuration.</description></item>
            /// <item><description><b>macos_keychain</b>: macOS keychain.</description></item>
            /// <item><description><b>amazon_mws_token</b>: Amazon MWS token.</description></item>
            /// <item><description><b>dynatrace_token</b>: Dynatrace token.</description></item>
            /// <item><description><b>java_keystore</b>: Java KeyStore (JKS).</description></item>
            /// <item><description><b>microsoft_sdf</b>: Microsoft SQL Server Compact Edition (CE) database.</description></item>
            /// <item><description><b>kubernetes_dashboard_cred</b>: user credential for Kubernetes Dashboard.</description></item>
            /// <item><description><b>atlassian_token</b>: Atlassian token.</description></item>
            /// <item><description><b>rdp</b>: remote desktop protocol (RDP).</description></item>
            /// <item><description><b>mailgun_key</b>: Mailgun webhook signing key.</description></item>
            /// <item><description><b>mailchimp_api_key</b>: API key for Mailchimp.</description></item>
            /// <item><description><b>netrc_cfg</b>: .netrc configuration file.</description></item>
            /// <item><description><b>openvpn_cfg</b>: OpenVPN client configuration.</description></item>
            /// <item><description><b>github_refresh_token</b>: GitHub refresh token.</description></item>
            /// <item><description><b>salesforce</b>: Salesforce credential.</description></item>
            /// <item><description><b>sendinblue</b>: Sendinblue token.</description></item>
            /// <item><description><b>pkcs_private_key</b>: PKCS#12 key.</description></item>
            /// <item><description><b>rubyonrails_passwd</b>: Ruby on Rails password file.</description></item>
            /// <item><description><b>filezilla_ftp</b>: FileZilla FTP configuration.</description></item>
            /// <item><description><b>databricks_token</b>: Databricks token.</description></item>
            /// <item><description><b>gitLab_personal_token</b>: personal access token for GitLab.</description></item>
            /// <item><description><b>rails_master_key</b>: Rails master key.</description></item>
            /// <item><description><b>sqlite</b>: SQLite3 or SQLite database.</description></item>
            /// <item><description><b>firefox_logins</b>: Firefox logon configuration.</description></item>
            /// <item><description><b>mailgun_private_token</b>: Mailgun private token.</description></item>
            /// <item><description><b>joomla_cfg</b>: Joomla configuration.</description></item>
            /// <item><description><b>hashicorp_terraform_token</b>: HashiCorp Terraform token.</description></item>
            /// <item><description><b>jetbrains_ides</b>: JetBrains IDEs configuration.</description></item>
            /// <item><description><b>heroku_api_key</b>: Heroku API key.</description></item>
            /// <item><description><b>messagebird_token</b>: MessageBird token.</description></item>
            /// <item><description><b>github_app_token</b>: GitHub app token.</description></item>
            /// <item><description><b>hashicorp_vault_token</b>: HashiCorp Vault token.</description></item>
            /// <item><description><b>pgp_private_key</b>: PGP private key.</description></item>
            /// <item><description><b>sshpasswd</b>: SSH password.</description></item>
            /// <item><description><b>huaweicloud_ak</b>: secret access key of a third-party cloud.</description></item>
            /// <item><description><b>aws_s3cmd</b>: AWS S3cmd configuration.</description></item>
            /// <item><description><b>php_config</b>: PHP configuration.</description></item>
            /// <item><description><b>common_private_key</b>: private key of a common type.</description></item>
            /// <item><description><b>microsoft_mdf</b>: Microsoft SQL Server database.</description></item>
            /// <item><description><b>mediawiki_cfg</b>: MediaWiki configuration.</description></item>
            /// <item><description><b>jenkins_cred</b>: Jenkins credential.</description></item>
            /// <item><description><b>rubygems_cred</b>: RubyGems credential.</description></item>
            /// <item><description><b>clojars_token</b>: Clojars token.</description></item>
            /// <item><description><b>phoenix_web_passwd</b>: Phoenix web credential.</description></item>
            /// <item><description><b>puttygen_private_key</b>: PuTTYgen private key.</description></item>
            /// <item><description><b>google_oauth_token</b>: Google OAuth access token.</description></item>
            /// <item><description><b>rubyonrails_cfg</b>: Ruby on Rails database configuration.</description></item>
            /// <item><description><b>lob_api_key</b>: Lob API key.</description></item>
            /// <item><description><b>pkcs_cred</b>: PKCS#12 certificate.</description></item>
            /// <item><description><b>otr_private_key</b>: Off-the-Record Messaging (OTR) private key.</description></item>
            /// <item><description><b>contentful_delivery_token</b>: delivery token for Contentful.</description></item>
            /// <item><description><b>digital_ocean_tugboat</b>: DigitalOcean Tugboat configuration.</description></item>
            /// <item><description><b>dsa_private_key</b>: Digital Signature Algorithm (DSA) private key.</description></item>
            /// <item><description><b>rails_app_token</b>: Rails app token.</description></item>
            /// <item><description><b>git_cred</b>: Git user credential.</description></item>
            /// <item><description><b>newrelic_api_key</b>: user API key for New Relic.</description></item>
            /// <item><description><b>github_hub</b>: hub configuration for storing GitHub tokens.</description></item>
            /// <item><description><b>rubygem</b>: RubyGems token.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>google_oauth_key</para>
            /// </summary>
            [NameInMap("SensitiveFileKey")]
            [Validation(Required=false)]
            public string SensitiveFileKey { get; set; }

            /// <summary>
            /// <para>The name of the alert type for the sensitive file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKeyLeak</para>
            /// </summary>
            [NameInMap("SensitiveFileName")]
            [Validation(Required=false)]
            public string SensitiveFileName { get; set; }

            /// <summary>
            /// <para>The number of unprocessed mirrors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnprocessedNum")]
            [Validation(Required=false)]
            public int? UnprocessedNum { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
